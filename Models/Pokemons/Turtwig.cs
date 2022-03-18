using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Turtwig Species to store common natural stats of all Turtwigs
	#region SpeciesTurtwig
	public class SpeciesTurtwig : PokemonSpecies
	{
#nullable enable
		private static SpeciesTurtwig? _instance = null;
#nullable restore
        public static SpeciesTurtwig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTurtwig();
                }
                return _instance;
            }
        }

		#region SpeciesTurtwig Constructor
		public SpeciesTurtwig() : base(
			387,
			"Turtwig",
			0.4,
			10.2,
			55, // HPs
			68, 64, // Attack & Defense
			45, 55, // Special Attack & Defense
			31		
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Bite",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Amnesia",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Nature-Power",
				"Superpower",
				"Secret-Power",
				"Tickle",
				"Sand-Tomb",
				"Bullet-Seed",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Rock-Climb",
				"Leaf-Storm",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Wide-Guard",
				"Heavy-Slam",
				"Round",
				"Grass-Pledge",
				"Work-Up",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Turtwig PokemonInstance Class
	#region Turtwig
	public class TurtwigInstance : PokemonInstance
	{
		#region Turtwig Constructors
		/// <summary>
		/// Turtwig Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TurtwigInstance(string nickname, int level)
		: base(
				SpeciesTurtwig.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtwig Builder only waiting for a Level
		/// </summary>
		public TurtwigInstance(int level)
		: base(
				SpeciesTurtwig.Instance, // PokemonInstance Species
				"Turtwig", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtwig Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TurtwigInstance() : base(
			SpeciesTurtwig.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}