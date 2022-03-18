using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Slowpoke Species to store common natural stats of all Slowpokes
	#region SpeciesSlowpoke
	public class SpeciesSlowpoke : PokemonSpecies
	{
#nullable enable
		private static SpeciesSlowpoke? _instance = null;
#nullable restore
        public static SpeciesSlowpoke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSlowpoke();
                }
                return _instance;
            }
        }

		#region SpeciesSlowpoke Constructor
		public SpeciesSlowpoke() : base(
			79,
			"Slowpoke",
			1.2,
			36.0,
			90, // HPs
			65, 65, // Attack & Defense
			40, 40, // Special Attack & Defense
			15		
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
				"Pay-Day",
				"Stomp",
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
				"Belly-Drum",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Whirlpool",
				"Hail",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Yawn",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Slack-Off",
				"Signal-Beam",
				"Block",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Me-First",
				"Aqua-Tail",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Heal-Pulse",
				"Incinerate",
				"Bulldoze",
				"Belch",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Slowpoke PokemonInstance Class
	#region Slowpoke
	public class SlowpokeInstance : PokemonInstance
	{
		#region Slowpoke Constructors
		/// <summary>
		/// Slowpoke Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SlowpokeInstance(string nickname, int level)
		: base(
				SpeciesSlowpoke.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowpoke Builder only waiting for a Level
		/// </summary>
		public SlowpokeInstance(int level)
		: base(
				SpeciesSlowpoke.Instance, // PokemonInstance Species
				"Slowpoke", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowpoke Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SlowpokeInstance() : base(
			SpeciesSlowpoke.Instance, // PokemonInstance Species
			Water.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}