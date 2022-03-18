using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Fraxure Species to store common natural stats of all Fraxures
	#region SpeciesFraxure
	public class SpeciesFraxure : PokemonSpecies
	{
#nullable enable
		private static SpeciesFraxure? _instance = null;
#nullable restore
        public static SpeciesFraxure Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFraxure();
                }
                return _instance;
            }
        }

		#region SpeciesFraxure Constructor
		public SpeciesFraxure() : base(
			611,
			"Fraxure",
			1.0,
			36.0,
			66, // HPs
			117, 70, // Attack & Defense
			40, 50, // Special Attack & Defense
			67		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Scratch",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Leer",
				"Roar",
				"Low-Kick",
				"Strength",
				"Dragon-Rage",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Outrage",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Shock-Wave",
				"Payback",
				"Assurance",
				"Fling",
				"Poison-Jab",
				"Aqua-Tail",
				"X-Scissor",
				"Dragon-Pulse",
				"Giga-Impact",
				"Shadow-Claw",
				"Draco-Meteor",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Dragon-Tail",
				"Dual-Chop",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Fraxure PokemonInstance Class
	#region Fraxure
	public class FraxureInstance : PokemonInstance
	{
		#region Fraxure Constructors
		/// <summary>
		/// Fraxure Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FraxureInstance(string nickname, int level)
		: base(
				SpeciesFraxure.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fraxure Builder only waiting for a Level
		/// </summary>
		public FraxureInstance(int level)
		: base(
				SpeciesFraxure.Instance, // PokemonInstance Species
				"Fraxure", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fraxure Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public FraxureInstance() : base(
			SpeciesFraxure.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}