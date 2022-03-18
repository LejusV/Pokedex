using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vivillon Species to store common natural stats of all Vivillons
	#region SpeciesVivillon
	public class SpeciesVivillon : PokemonSpecies
	{
#nullable enable
		private static SpeciesVivillon? _instance = null;
#nullable restore
        public static SpeciesVivillon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVivillon();
                }
                return _instance;
            }
        }

		#region SpeciesVivillon Constructor
		public SpeciesVivillon() : base(
			666,
			"Vivillon",
			1.2,
			17.0,
			80, // HPs
			52, 50, // Attack & Defense
			90, 50, // Special Attack & Defense
			89		
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
				"Gust",
				"Supersonic",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Aromatherapy",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Bug-Bite",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Electroweb",
				"Hurricane",
				"Draining-Kiss",
				"Confide",
				"Powder",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Vivillon PokemonInstance Class
	#region Vivillon
	public class VivillonInstance : PokemonInstance
	{
		#region Vivillon Constructors
		/// <summary>
		/// Vivillon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VivillonInstance(string nickname, int level)
		: base(
				SpeciesVivillon.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vivillon Builder only waiting for a Level
		/// </summary>
		public VivillonInstance(int level)
		: base(
				SpeciesVivillon.Instance, // PokemonInstance Species
				"Vivillon", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vivillon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public VivillonInstance() : base(
			SpeciesVivillon.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}