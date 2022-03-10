using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Slowbro Species to store common natural stats of all Slowbros
	#region SpeciesSlowbro
	public class SpeciesSlowbro : PokemonSpecies
	{
#nullable enable
		private static SpeciesSlowbro? _instance = null;
#nullable restore
        public static SpeciesSlowbro Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSlowbro();
                }
                return _instance;
            }
        }

		#region SpeciesSlowbro Constructor
		public SpeciesSlowbro() : base(
			"Slowbro",
			1.6,
			78.5,
			95, // HPs
			75, 110, // Attack & Defense
			100, 80, // Special Attack & Defense
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
				"Mega-Punch",
				"Pay-Day",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Disable",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Wave",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
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
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Yawn",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Slack-Off",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Foul-Play",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Heal-Pulse",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Slowbro PokemonInstance Class
	#region Slowbro
	public class SlowbroInstance : PokemonInstance
	{
		#region Slowbro Constructors
		/// <summary>
		/// Slowbro Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SlowbroInstance(string nickname, int level)
		: base(
				80,
				SpeciesSlowbro.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowbro Builder only waiting for a Level
		/// </summary>
		public SlowbroInstance(int level)
		: base(
				80,
				SpeciesSlowbro.Instance, // PokemonInstance Species
				"Slowbro", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowbro Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Slowbro() : base(
			80,
			SpeciesSlowbro.Instance, // PokemonInstance Species
			Water.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}