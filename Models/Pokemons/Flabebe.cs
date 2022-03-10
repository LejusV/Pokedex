using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Flabebe Species to store common natural stats of all Flabebes
	#region SpeciesFlabebe
	public class SpeciesFlabebe : PokemonSpecies
	{
#nullable enable
		private static SpeciesFlabebe? _instance = null;
#nullable restore
        public static SpeciesFlabebe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFlabebe();
                }
                return _instance;
            }
        }

		#region SpeciesFlabebe Constructor
		public SpeciesFlabebe() : base(
			"Flabebe",
			0.1,
			0.1,
			44, // HPs
			38, 39, // Attack & Defense
			61, 79, // Special Attack & Defense
			42		
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
				"Vine-Whip",
				"Tackle",
				"Razor-Leaf",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Psychic",
				"Double-Team",
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
				"Camouflage",
				"Aromatherapy",
				"Covet",
				"Magical-Leaf",
				"Calm-Mind",
				"Lucky-Chant",
				"Copycat",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Petal-Blizzard",
				"Grassy-Terrain",
				"Misty-Terrain",
				"Fairy-Wind",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion

	//Flabebe PokemonInstance Class
	#region Flabebe
	public class FlabebeInstance : PokemonInstance
	{
		#region Flabebe Constructors
		/// <summary>
		/// Flabebe Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FlabebeInstance(string nickname, int level)
		: base(
				669,
				SpeciesFlabebe.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flabebe Builder only waiting for a Level
		/// </summary>
		public FlabebeInstance(int level)
		: base(
				669,
				SpeciesFlabebe.Instance, // PokemonInstance Species
				"Flabebe", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flabebe Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Flabebe() : base(
			669,
			SpeciesFlabebe.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}