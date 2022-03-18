using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Axew Species to store common natural stats of all Axews
	#region SpeciesAxew
	public class SpeciesAxew : PokemonSpecies
	{
#nullable enable
		private static SpeciesAxew? _instance = null;
#nullable restore
        public static SpeciesAxew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAxew();
                }
                return _instance;
            }
        }

		#region SpeciesAxew Constructor
		public SpeciesAxew() : base(
			610,
			"Axew",
			0.6,
			18.0,
			46, // HPs
			87, 60, // Attack & Defense
			30, 40, // Special Attack & Defense
			57		
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Leer",
				"Roar",
				"Counter",
				"Strength",
				"Dragon-Rage",
				"Dig",
				"Toxic",
				"Double-Team",
				"Harden",
				"Focus-Energy",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Endure",
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
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Dragon-Pulse",
				"Giga-Impact",
				"Draco-Meteor",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Dual-Chop",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Axew PokemonInstance Class
	#region Axew
	public class AxewInstance : PokemonInstance
	{
		#region Axew Constructors
		/// <summary>
		/// Axew Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AxewInstance(string nickname, int level)
		: base(
				SpeciesAxew.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Axew Builder only waiting for a Level
		/// </summary>
		public AxewInstance(int level)
		: base(
				SpeciesAxew.Instance, // PokemonInstance Species
				"Axew", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Axew Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AxewInstance() : base(
			SpeciesAxew.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}