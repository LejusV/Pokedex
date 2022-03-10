using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wigglytuff Species to store common natural stats of all Wigglytuffs
	#region SpeciesWigglytuff
	public class SpeciesWigglytuff : PokemonSpecies
	{
#nullable enable
		private static SpeciesWigglytuff? _instance = null;
#nullable restore
        public static SpeciesWigglytuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWigglytuff();
                }
                return _instance;
            }
        }

		#region SpeciesWigglytuff Constructor
		public SpeciesWigglytuff() : base(
			"Wigglytuff",
			1.0,
			12.0,
			140, // HPs
			70, 45, // Attack & Defense
			85, 50, // Special Attack & Defense
			45		
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
				"Sing",
				"Disable",
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
				"Dig",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
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
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Play-Rough",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Wigglytuff PokemonInstance Class
	#region Wigglytuff
	public class WigglytuffInstance : PokemonInstance
	{
		#region Wigglytuff Constructors
		/// <summary>
		/// Wigglytuff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WigglytuffInstance(string nickname, int level)
		: base(
				40,
				SpeciesWigglytuff.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wigglytuff Builder only waiting for a Level
		/// </summary>
		public WigglytuffInstance(int level)
		: base(
				40,
				SpeciesWigglytuff.Instance, // PokemonInstance Species
				"Wigglytuff", level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wigglytuff Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Wigglytuff() : base(
			40,
			SpeciesWigglytuff.Instance, // PokemonInstance Species
			Normal.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}