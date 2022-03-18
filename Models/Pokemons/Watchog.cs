using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Watchog Species to store common natural stats of all Watchogs
	#region SpeciesWatchog
	public class SpeciesWatchog : PokemonSpecies
	{
#nullable enable
		private static SpeciesWatchog? _instance = null;
#nullable restore
        public static SpeciesWatchog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWatchog();
                }
                return _instance;
            }
        }

		#region SpeciesWatchog Constructor
		public SpeciesWatchog() : base(
			505,
			"Watchog",
			1.1,
			27.0,
			60, // HPs
			85, 69, // Attack & Defense
			60, 69, // Special Attack & Defense
			77		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Slam",
				"Sand-Attack",
				"Tackle",
				"Leer",
				"Bite",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Focus-Energy",
				"Bide",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
				"Detect",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Fling",
				"Last-Resort",
				"Aqua-Tail",
				"Seed-Bomb",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Gunk-Shot",
				"Grass-Knot",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Rototiller",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Watchog PokemonInstance Class
	#region Watchog
	public class WatchogInstance : PokemonInstance
	{
		#region Watchog Constructors
		/// <summary>
		/// Watchog Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WatchogInstance(string nickname, int level)
		: base(
				SpeciesWatchog.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Watchog Builder only waiting for a Level
		/// </summary>
		public WatchogInstance(int level)
		: base(
				SpeciesWatchog.Instance, // PokemonInstance Species
				"Watchog", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Watchog Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public WatchogInstance() : base(
			SpeciesWatchog.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}