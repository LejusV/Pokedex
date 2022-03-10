using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Snorlax Species to store common natural stats of all Snorlaxs
	#region SpeciesSnorlax
	public class SpeciesSnorlax : PokemonSpecies
	{
#nullable enable
		private static SpeciesSnorlax? _instance = null;
#nullable restore
        public static SpeciesSnorlax Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSnorlax();
                }
                return _instance;
            }
        }

		#region SpeciesSnorlax Constructor
		public SpeciesSnorlax() : base(
			"Snorlax",
			2.1,
			460.0,
			160, // HPs
			110, 65, // Attack & Defense
			65, 110, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Whirlwind",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
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
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Psychic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Reflect",
				"Bide",
				"Metronome",
				"Self-Destruct",
				"Lick",
				"Fire-Blast",
				"Skull-Bash",
				"Amnesia",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Recycle",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Block",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Gunk-Shot",
				"Iron-Head",
				"Captivate",
				"Smack-Down",
				"Heavy-Slam",
				"After-You",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Belch",
				"Confide",
				"Power-Up-Punch",
				"High-Horsepower"
			};
		}
		#endregion
	}
	#endregion

	//Snorlax PokemonInstance Class
	#region Snorlax
	public class SnorlaxInstance : PokemonInstance
	{
		#region Snorlax Constructors
		/// <summary>
		/// Snorlax Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SnorlaxInstance(string nickname, int level)
		: base(
				143,
				SpeciesSnorlax.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorlax Builder only waiting for a Level
		/// </summary>
		public SnorlaxInstance(int level)
		: base(
				143,
				SpeciesSnorlax.Instance, // PokemonInstance Species
				"Snorlax", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorlax Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Snorlax() : base(
			143,
			SpeciesSnorlax.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}