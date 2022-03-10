using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zebstrika Species to store common natural stats of all Zebstrikas
	#region SpeciesZebstrika
	public class SpeciesZebstrika : PokemonSpecies
	{
#nullable enable
		private static SpeciesZebstrika? _instance = null;
#nullable restore
        public static SpeciesZebstrika Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZebstrika();
                }
                return _instance;
            }
        }

		#region SpeciesZebstrika Constructor
		public SpeciesZebstrika() : base(
			"Zebstrika",
			1.6,
			79.5,
			75, // HPs
			100, 63, // Attack & Defense
			80, 63, // Special Attack & Defense
			116		
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
				"Stomp",
				"Thrash",
				"Tail-Whip",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Charge",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"Magnet-Rise",
				"Giga-Impact",
				"Discharge",
				"Charge-Beam",
				"Flame-Charge",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Zebstrika PokemonInstance Class
	#region Zebstrika
	public class ZebstrikaInstance : PokemonInstance
	{
		#region Zebstrika Constructors
		/// <summary>
		/// Zebstrika Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZebstrikaInstance(string nickname, int level)
		: base(
				523,
				SpeciesZebstrika.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zebstrika Builder only waiting for a Level
		/// </summary>
		public ZebstrikaInstance(int level)
		: base(
				523,
				SpeciesZebstrika.Instance, // PokemonInstance Species
				"Zebstrika", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zebstrika Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Zebstrika() : base(
			523,
			SpeciesZebstrika.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}