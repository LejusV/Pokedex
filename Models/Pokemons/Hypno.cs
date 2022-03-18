using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hypno Species to store common natural stats of all Hypnos
	#region SpeciesHypno
	public class SpeciesHypno : PokemonSpecies
	{
#nullable enable
		private static SpeciesHypno? _instance = null;
#nullable restore
        public static SpeciesHypno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHypno();
                }
                return _instance;
            }
        }

		#region SpeciesHypno Constructor
		public SpeciesHypno() : base(
			97,
			"Hypno",
			1.6,
			75.6,
			85, // HPs
			73, 70, // Attack & Defense
			73, 115, // Special Attack & Defense
			67		
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
				"Hyper-Beam",
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
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
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
				"Drain-Punch",
				"Focus-Blast",
				"Switcheroo",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Synchronoise",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Hypno PokemonInstance Class
	#region Hypno
	public class HypnoInstance : PokemonInstance
	{
		#region Hypno Constructors
		/// <summary>
		/// Hypno Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HypnoInstance(string nickname, int level)
		: base(
				SpeciesHypno.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hypno Builder only waiting for a Level
		/// </summary>
		public HypnoInstance(int level)
		: base(
				SpeciesHypno.Instance, // PokemonInstance Species
				"Hypno", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hypno Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HypnoInstance() : base(
			SpeciesHypno.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}