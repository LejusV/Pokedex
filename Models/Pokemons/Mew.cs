using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mew Species to store common natural stats of all Mews
	#region SpeciesMew
	public class SpeciesMew : PokemonSpecies
	{
#nullable enable
		private static SpeciesMew? _instance = null;
#nullable restore
        public static SpeciesMew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMew();
                }
                return _instance;
            }
        }

		#region SpeciesMew Constructor
		public SpeciesMew() : base(
			"Mew",
			0.4,
			4.0,
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100		
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
				"Mega-Punch",
				"Pay-Day",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Whirlwind",
				"Fly",
				"Bind",
				"Mega-Kick",
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Water-Gun",
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
				"Mega-Drain",
				"Solar-Beam",
				"String-Shot",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Teleport",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Self-Destruct",
				"Egg-Bomb",
				"Fire-Blast",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Amnesia",
				"Soft-Boiled",
				"Dream-Eater",
				"Leech-Life",
				"Sky-Attack",
				"Transform",
				"Flash",
				"Psywave",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Outrage",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Dynamic-Punch",
				"Dragon-Breath",
				"Baton-Pass",
				"Sweet-Scent",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Fake-Out",
				"Uproar",
				"Heat-Wave",
				"Hail",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Superpower",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Air-Cutter",
				"Overheat",
				"Rock-Tomb",
				"Silver-Wind",
				"Signal-Beam",
				"Bullet-Seed",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Dragon-Claw",
				"Bulk-Up",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Gravity",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Embargo",
				"Fling",
				"Gastro-Acid",
				"Me-First",
				"Last-Resort",
				"Worry-Seed",
				"Sucker-Punch",
				"Magnet-Rise",
				"Aura-Sphere",
				"Rock-Polish",
				"Poison-Jab",
				"Dark-Pulse",
				"Aqua-Tail",
				"Seed-Bomb",
				"X-Scissor",
				"Dragon-Pulse",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Nasty-Plot",
				"Avalanche",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Rock-Climb",
				"Defog",
				"Trick-Room",
				"Gunk-Shot",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Bug-Bite",
				"Charge-Beam",
				"Ominous-Wind",
				"Hone-Claws",
				"Wonder-Room",
				"Psyshock",
				"Venoshock",
				"Telekinesis",
				"Magic-Room",
				"Smack-Down",
				"Sludge-Wave",
				"Flame-Charge",
				"Low-Sweep",
				"Foul-Play",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Ally-Switch",
				"Scald",
				"Sky-Drop",
				"Incinerate",
				"Quash",
				"Acrobatics",
				"Reflect-Type",
				"Retaliate",
				"Volt-Switch",
				"Struggle-Bug",
				"Bulldoze",
				"Frost-Breath",
				"Dragon-Tail",
				"Work-Up",
				"Electroweb",
				"Wild-Charge",
				"Drill-Run",
				"Dual-Chop",
				"Snarl",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Power-Up-Punch",
				"Smart-Strike",
				"Brutal-Swing",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion

	//Mew PokemonInstance Class
	#region Mew
	public class MewInstance : PokemonInstance
	{
		#region Mew Constructors
		/// <summary>
		/// Mew Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MewInstance(string nickname, int level)
		: base(
				151,
				SpeciesMew.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mew Builder only waiting for a Level
		/// </summary>
		public MewInstance(int level)
		: base(
				151,
				SpeciesMew.Instance, // PokemonInstance Species
				"Mew", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mew Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Mew() : base(
			151,
			SpeciesMew.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}