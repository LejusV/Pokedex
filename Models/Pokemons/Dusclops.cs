using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dusclops Species to store common natural stats of all Dusclopss
	#region SpeciesDusclops
	public class SpeciesDusclops : PokemonSpecies
	{
#nullable enable
		private static SpeciesDusclops? _instance = null;
#nullable restore
        public static SpeciesDusclops Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDusclops();
                }
                return _instance;
            }
        }

		#region SpeciesDusclops Constructor
		public SpeciesDusclops() : base(
			"Dusclops",
			1.6,
			30.6,
			40, // HPs
			70, 130, // Attack & Defense
			60, 130, // Special Attack & Defense
			25		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Bind",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Metronome",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Shadow-Punch",
				"Calm-Mind",
				"Gravity",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Wonder-Room",
				"Telekinesis",
				"Round",
				"Hex",
				"Bulldoze",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Dusclops PokemonInstance Class
	#region Dusclops
	public class DusclopsInstance : PokemonInstance
	{
		#region Dusclops Constructors
		/// <summary>
		/// Dusclops Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DusclopsInstance(string nickname, int level)
		: base(
				356,
				SpeciesDusclops.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusclops Builder only waiting for a Level
		/// </summary>
		public DusclopsInstance(int level)
		: base(
				356,
				SpeciesDusclops.Instance, // PokemonInstance Species
				"Dusclops", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusclops Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dusclops() : base(
			356,
			SpeciesDusclops.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}