using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Golduck Species to store common natural stats of all Golducks
	#region SpeciesGolduck
	public class SpeciesGolduck : PokemonSpecies
	{
#nullable enable
		private static SpeciesGolduck? _instance = null;
#nullable restore
        public static SpeciesGolduck Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGolduck();
                }
                return _instance;
            }
        }

		#region SpeciesGolduck Constructor
		public SpeciesGolduck() : base(
			55,
			"Golduck",
			1.7,
			76.6,
			80, // HPs
			82, 78, // Attack & Defense
			95, 80, // Special Attack & Defense
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
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
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
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Role-Play",
				"Brick-Break",
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
				"Me-First",
				"Worry-Seed",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Rock-Climb",
				"Captivate",
				"Aqua-Jet",
				"Hone-Claws",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Soak",
				"Low-Sweep",
				"Round",
				"Scald",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Golduck PokemonInstance Class
	#region Golduck
	public class GolduckInstance : PokemonInstance
	{
		#region Golduck Constructors
		/// <summary>
		/// Golduck Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GolduckInstance(string nickname, int level)
		: base(
				SpeciesGolduck.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golduck Builder only waiting for a Level
		/// </summary>
		public GolduckInstance(int level)
		: base(
				SpeciesGolduck.Instance, // PokemonInstance Species
				"Golduck", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golduck Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GolduckInstance() : base(
			SpeciesGolduck.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}