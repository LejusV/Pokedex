using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Drowzee Species to store common natural stats of all Drowzees
	#region SpeciesDrowzee
	public class SpeciesDrowzee : PokemonSpecies
	{
#nullable enable
		private static SpeciesDrowzee? _instance = null;
#nullable restore
        public static SpeciesDrowzee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDrowzee();
                }
                return _instance;
            }
        }

		#region SpeciesDrowzee Constructor
		public SpeciesDrowzee() : base(
			96,
			"Drowzee",
			1.0,
			32.4,
			60, // HPs
			48, 45, // Attack & Defense
			43, 90, // Special Attack & Defense
			42		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Disable",
				"Psybeam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Meditate",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Skull-Bash",
				"Dream-Eater",
				"Poison-Gas",
				"Flash",
				"Psywave",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Flatter",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Assist",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Fling",
				"Guard-Swap",
				"Drain-Punch",
				"Nasty-Plot",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Power-Split",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Synchronoise",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Drowzee PokemonInstance Class
	#region Drowzee
	public class DrowzeeInstance : PokemonInstance
	{
		#region Drowzee Constructors
		/// <summary>
		/// Drowzee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DrowzeeInstance(string nickname, int level)
		: base(
				SpeciesDrowzee.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drowzee Builder only waiting for a Level
		/// </summary>
		public DrowzeeInstance(int level)
		: base(
				SpeciesDrowzee.Instance, // PokemonInstance Species
				"Drowzee", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drowzee Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DrowzeeInstance() : base(
			SpeciesDrowzee.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}