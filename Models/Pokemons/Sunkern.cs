using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sunkern Species to store common natural stats of all Sunkerns
	#region SpeciesSunkern
	public class SpeciesSunkern : PokemonSpecies
	{
#nullable enable
		private static SpeciesSunkern? _instance = null;
#nullable restore
        public static SpeciesSunkern Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSunkern();
                }
                return _instance;
            }
        }

		#region SpeciesSunkern Constructor
		public SpeciesSunkern() : base(
			191,
			"Sunkern",
			0.3,
			1.8,
			30, // HPs
			30, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			30		
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
				"Swords-Dance",
				"Cut",
				"Double-Edge",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Sweet-Scent",
				"Morning-Sun",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Ingrain",
				"Endeavor",
				"Secret-Power",
				"Grass-Whistle",
				"Bullet-Seed",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Captivate",
				"Grass-Knot",
				"After-You",
				"Round",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Sunkern PokemonInstance Class
	#region Sunkern
	public class SunkernInstance : PokemonInstance
	{
		#region Sunkern Constructors
		/// <summary>
		/// Sunkern Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SunkernInstance(string nickname, int level)
		: base(
				SpeciesSunkern.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunkern Builder only waiting for a Level
		/// </summary>
		public SunkernInstance(int level)
		: base(
				SpeciesSunkern.Instance, // PokemonInstance Species
				"Sunkern", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunkern Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SunkernInstance() : base(
			SpeciesSunkern.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}