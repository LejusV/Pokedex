using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sunflora Species to store common natural stats of all Sunfloras
	#region SpeciesSunflora
	public class SpeciesSunflora : PokemonSpecies
	{
#nullable enable
		private static SpeciesSunflora? _instance = null;
#nullable restore
        public static SpeciesSunflora Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSunflora();
                }
                return _instance;
            }
        }

		#region SpeciesSunflora Constructor
		public SpeciesSunflora() : base(
			"Sunflora",
			0.8,
			8.5,
			75, // HPs
			75, 55, // Attack & Defense
			105, 85, // Special Attack & Defense
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
				"Pound",
				"Swords-Dance",
				"Cut",
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
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
				"Sweet-Scent",
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
				"Giga-Impact",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"After-You",
				"Round",
				"Petal-Blizzard",
				"Flower-Shield",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Sunflora PokemonInstance Class
	#region Sunflora
	public class SunfloraInstance : PokemonInstance
	{
		#region Sunflora Constructors
		/// <summary>
		/// Sunflora Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SunfloraInstance(string nickname, int level)
		: base(
				192,
				SpeciesSunflora.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunflora Builder only waiting for a Level
		/// </summary>
		public SunfloraInstance(int level)
		: base(
				192,
				SpeciesSunflora.Instance, // PokemonInstance Species
				"Sunflora", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunflora Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Sunflora() : base(
			192,
			SpeciesSunflora.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}