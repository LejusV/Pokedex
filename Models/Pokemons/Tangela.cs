using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tangela Species to store common natural stats of all Tangelas
	#region SpeciesTangela
	public class SpeciesTangela : PokemonSpecies
	{
#nullable enable
		private static SpeciesTangela? _instance = null;
#nullable restore
        public static SpeciesTangela Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTangela();
                }
                return _instance;
            }
        }

		#region SpeciesTangela Constructor
		public SpeciesTangela() : base(
			114,
			"Tangela",
			1.0,
			35.0,
			65, // HPs
			55, 115, // Attack & Defense
			100, 40, // Special Attack & Defense
			60		
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
				"Bind",
				"Slam",
				"Vine-Whip",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Confusion",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Skull-Bash",
				"Constrict",
				"Amnesia",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Tickle",
				"Bullet-Seed",
				"Shock-Wave",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Wring-Out",
				"Power-Swap",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Rage-Powder",
				"Round",
				"Grassy-Terrain",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Tangela PokemonInstance Class
	#region Tangela
	public class TangelaInstance : PokemonInstance
	{
		#region Tangela Constructors
		/// <summary>
		/// Tangela Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TangelaInstance(string nickname, int level)
		: base(
				SpeciesTangela.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangela Builder only waiting for a Level
		/// </summary>
		public TangelaInstance(int level)
		: base(
				SpeciesTangela.Instance, // PokemonInstance Species
				"Tangela", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangela Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TangelaInstance() : base(
			SpeciesTangela.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}