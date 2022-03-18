using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Duskull Species to store common natural stats of all Duskulls
	#region SpeciesDuskull
	public class SpeciesDuskull : PokemonSpecies
	{
#nullable enable
		private static SpeciesDuskull? _instance = null;
#nullable restore
        public static SpeciesDuskull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDuskull();
                }
                return _instance;
            }
        }

		#region SpeciesDuskull Constructor
		public SpeciesDuskull() : base(
			355,
			"Duskull",
			0.8,
			15.0,
			20, // HPs
			40, 90, // Attack & Defense
			30, 90, // Special Attack & Defense
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Foresight",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Skill-Swap",
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Calm-Mind",
				"Gravity",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Dark-Pulse",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Wonder-Room",
				"Telekinesis",
				"Round",
				"Hex",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Duskull PokemonInstance Class
	#region Duskull
	public class DuskullInstance : PokemonInstance
	{
		#region Duskull Constructors
		/// <summary>
		/// Duskull Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DuskullInstance(string nickname, int level)
		: base(
				SpeciesDuskull.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duskull Builder only waiting for a Level
		/// </summary>
		public DuskullInstance(int level)
		: base(
				SpeciesDuskull.Instance, // PokemonInstance Species
				"Duskull", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duskull Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DuskullInstance() : base(
			SpeciesDuskull.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}