using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chansey Species to store common natural stats of all Chanseys
	#region SpeciesChansey
	public class SpeciesChansey : PokemonSpecies
	{
#nullable enable
		private static SpeciesChansey? _instance = null;
#nullable restore
        public static SpeciesChansey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChansey();
                }
                return _instance;
            }
        }

		#region SpeciesChansey Constructor
		public SpeciesChansey() : base(
			113,
			"Chansey",
			1.1,
			34.6,
			250, // HPs
			5, 5, // Attack & Defense
			35, 105, // Special Attack & Defense
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
				"Pound",
				"Double-Slap",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Sing",
				"Flamethrower",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Minimize",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Egg-Bomb",
				"Fire-Blast",
				"Skull-Bash",
				"Soft-Boiled",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Recycle",
				"Brick-Break",
				"Endeavor",
				"Skill-Swap",
				"Refresh",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Aromatherapy",
				"Rock-Tomb",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Giga-Impact",
				"Mud-Bomb",
				"Zen-Headbutt",
				"Rock-Climb",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Incinerate",
				"Retaliate",
				"Bestow",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Chansey PokemonInstance Class
	#region Chansey
	public class ChanseyInstance : PokemonInstance
	{
		#region Chansey Constructors
		/// <summary>
		/// Chansey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChanseyInstance(string nickname, int level)
		: base(
				SpeciesChansey.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chansey Builder only waiting for a Level
		/// </summary>
		public ChanseyInstance(int level)
		: base(
				SpeciesChansey.Instance, // PokemonInstance Species
				"Chansey", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chansey Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ChanseyInstance() : base(
			SpeciesChansey.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}