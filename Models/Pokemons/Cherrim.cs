using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cherrim Species to store common natural stats of all Cherrims
	#region SpeciesCherrim
	public class SpeciesCherrim : PokemonSpecies
	{
#nullable enable
		private static SpeciesCherrim? _instance = null;
#nullable restore
        public static SpeciesCherrim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCherrim();
                }
                return _instance;
            }
        }

		#region SpeciesCherrim Constructor
		public SpeciesCherrim() : base(
			"Cherrim",
			0.5,
			9.3,
			70, // HPs
			60, 70, // Attack & Defense
			87, 78, // Special Attack & Defense
			85		
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
				"Tackle",
				"Take-Down",
				"Hyper-Beam",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Morning-Sun",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Secret-Power",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Petal-Blizzard",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Cherrim PokemonInstance Class
	#region Cherrim
	public class CherrimInstance : PokemonInstance
	{
		#region Cherrim Constructors
		/// <summary>
		/// Cherrim Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CherrimInstance(string nickname, int level)
		: base(
				421,
				SpeciesCherrim.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherrim Builder only waiting for a Level
		/// </summary>
		public CherrimInstance(int level)
		: base(
				421,
				SpeciesCherrim.Instance, // PokemonInstance Species
				"Cherrim", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherrim Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cherrim() : base(
			421,
			SpeciesCherrim.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}