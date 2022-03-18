using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bellossom Species to store common natural stats of all Bellossoms
	#region SpeciesBellossom
	public class SpeciesBellossom : PokemonSpecies
	{
#nullable enable
		private static SpeciesBellossom? _instance = null;
#nullable restore
        public static SpeciesBellossom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBellossom();
                }
                return _instance;
            }
        }

		#region SpeciesBellossom Constructor
		public SpeciesBellossom() : base(
			182,
			"Bellossom",
			0.4,
			5.8,
			75, // HPs
			80, 95, // Attack & Defense
			90, 100, // Special Attack & Defense
			50		
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
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Stun-Spore",
				"Petal-Dance",
				"Toxic",
				"Mimic",
				"Double-Team",
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
				"Secret-Power",
				"Bullet-Seed",
				"Magical-Leaf",
				"Leaf-Blade",
				"Natural-Gift",
				"Fling",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Quiver-Dance",
				"After-You",
				"Round",
				"Petal-Blizzard",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Bellossom PokemonInstance Class
	#region Bellossom
	public class BellossomInstance : PokemonInstance
	{
		#region Bellossom Constructors
		/// <summary>
		/// Bellossom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BellossomInstance(string nickname, int level)
		: base(
				SpeciesBellossom.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellossom Builder only waiting for a Level
		/// </summary>
		public BellossomInstance(int level)
		: base(
				SpeciesBellossom.Instance, // PokemonInstance Species
				"Bellossom", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellossom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BellossomInstance() : base(
			SpeciesBellossom.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}