using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Floette Species to store common natural stats of all Floettes
	#region SpeciesFloette
	public class SpeciesFloette : PokemonSpecies
	{
#nullable enable
		private static SpeciesFloette? _instance = null;
#nullable restore
        public static SpeciesFloette Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFloette();
                }
                return _instance;
            }
        }

		#region SpeciesFloette Constructor
		public SpeciesFloette() : base(
			"Floette",
			0.2,
			0.9,
			54, // HPs
			45, 47, // Attack & Defense
			75, 98, // Special Attack & Defense
			52		
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
				"Aromatherapy",
				"Covet",
				"Magical-Leaf",
				"Calm-Mind",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
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
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Floette PokemonInstance Class
	#region Floette
	public class FloetteInstance : PokemonInstance
	{
		#region Floette Constructors
		/// <summary>
		/// Floette Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FloetteInstance(string nickname, int level)
		: base(
				670,
				SpeciesFloette.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floette Builder only waiting for a Level
		/// </summary>
		public FloetteInstance(int level)
		: base(
				670,
				SpeciesFloette.Instance, // PokemonInstance Species
				"Floette", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floette Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Floette() : base(
			670,
			SpeciesFloette.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}