using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Psyduck Species to store common natural stats of all Psyducks
	#region SpeciesPsyduck
	public class SpeciesPsyduck : PokemonSpecies
	{
#nullable enable
		private static SpeciesPsyduck? _instance = null;
#nullable restore
        public static SpeciesPsyduck Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPsyduck();
                }
                return _instance;
            }
        }

		#region SpeciesPsyduck Constructor
		public SpeciesPsyduck() : base(
			"Psyduck",
			0.8,
			19.6,
			50, // HPs
			52, 48, // Attack & Defense
			65, 50, // Special Attack & Defense
			55		
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
				"Mega-Punch",
				"Pay-Day",
				"Ice-Punch",
				"Scratch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Disable",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Amnesia",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Psych-Up",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Role-Play",
				"Brick-Break",
				"Yawn",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Aerial-Ace",
				"Water-Sport",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Worry-Seed",
				"Aqua-Tail",
				"Shadow-Claw",
				"Mud-Bomb",
				"Zen-Headbutt",
				"Captivate",
				"Hone-Claws",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Synchronoise",
				"Soak",
				"Simple-Beam",
				"Round",
				"Clear-Smog",
				"Scald",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Psyduck PokemonInstance Class
	#region Psyduck
	public class PsyduckInstance : PokemonInstance
	{
		#region Psyduck Constructors
		/// <summary>
		/// Psyduck Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PsyduckInstance(string nickname, int level)
		: base(
				54,
				SpeciesPsyduck.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Psyduck Builder only waiting for a Level
		/// </summary>
		public PsyduckInstance(int level)
		: base(
				54,
				SpeciesPsyduck.Instance, // PokemonInstance Species
				"Psyduck", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Psyduck Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Psyduck() : base(
			54,
			SpeciesPsyduck.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}