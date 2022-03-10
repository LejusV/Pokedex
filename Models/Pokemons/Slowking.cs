using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Slowking Species to store common natural stats of all Slowkings
	#region SpeciesSlowking
	public class SpeciesSlowking : PokemonSpecies
	{
#nullable enable
		private static SpeciesSlowking? _instance = null;
#nullable restore
        public static SpeciesSlowking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSlowking();
                }
                return _instance;
            }
        }

		#region SpeciesSlowking Constructor
		public SpeciesSlowking() : base(
			"Slowking",
			2.0,
			79.5,
			95, // HPs
			75, 80, // Attack & Defense
			100, 110, // Special Attack & Defense
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
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Disable",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Wave",
				"Earthquake",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
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
				"Signal-Beam",
				"Iron-Defense",
				"Block",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Trump-Card",
				"Aqua-Tail",
				"Power-Gem",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
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
				"Quash",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Slowking PokemonInstance Class
	#region Slowking
	public class SlowkingInstance : PokemonInstance
	{
		#region Slowking Constructors
		/// <summary>
		/// Slowking Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SlowkingInstance(string nickname, int level)
		: base(
				199,
				SpeciesSlowking.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowking Builder only waiting for a Level
		/// </summary>
		public SlowkingInstance(int level)
		: base(
				199,
				SpeciesSlowking.Instance, // PokemonInstance Species
				"Slowking", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowking Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Slowking() : base(
			199,
			SpeciesSlowking.Instance, // PokemonInstance Species
			Water.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}