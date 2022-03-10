using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Florges Species to store common natural stats of all Florgess
	#region SpeciesFlorges
	public class SpeciesFlorges : PokemonSpecies
	{
#nullable enable
		private static SpeciesFlorges? _instance = null;
#nullable restore
        public static SpeciesFlorges Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFlorges();
                }
                return _instance;
            }
        }

		#region SpeciesFlorges Constructor
		public SpeciesFlorges() : base(
			"Florges",
			1.1,
			10.0,
			78, // HPs
			65, 68, // Attack & Defense
			112, 154, // Special Attack & Defense
			75		
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
				"Hyper-Beam",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Wish",
				"Magic-Coat",
				"Endeavor",
				"Secret-Power",
				"Aromatherapy",
				"Covet",
				"Magical-Leaf",
				"Calm-Mind",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Petal-Blizzard",
				"Disarming-Voice",
				"Flower-Shield",
				"Grassy-Terrain",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Florges PokemonInstance Class
	#region Florges
	public class FlorgesInstance : PokemonInstance
	{
		#region Florges Constructors
		/// <summary>
		/// Florges Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FlorgesInstance(string nickname, int level)
		: base(
				671,
				SpeciesFlorges.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Florges Builder only waiting for a Level
		/// </summary>
		public FlorgesInstance(int level)
		: base(
				671,
				SpeciesFlorges.Instance, // PokemonInstance Species
				"Florges", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Florges Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Florges() : base(
			671,
			SpeciesFlorges.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}