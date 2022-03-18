using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Timburr Species to store common natural stats of all Timburrs
	#region SpeciesTimburr
	public class SpeciesTimburr : PokemonSpecies
	{
#nullable enable
		private static SpeciesTimburr? _instance = null;
#nullable restore
        public static SpeciesTimburr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTimburr();
                }
                return _instance;
            }
        }

		#region SpeciesTimburr Constructor
		public SpeciesTimburr() : base(
			532,
			"Timburr",
			0.6,
			12.5,
			75, // HPs
			80, 55, // Attack & Defense
			25, 35, // Special Attack & Defense
			35		
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
				"Comet-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Leer",
				"Low-Kick",
				"Counter",
				"Strength",
				"Rock-Throw",
				"Dig",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Mach-Punch",
				"Scary-Face",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Bulk-Up",
				"Wake-Up-Slap",
				"Hammer-Arm",
				"Payback",
				"Fling",
				"Force-Palm",
				"Poison-Jab",
				"Drain-Punch",
				"Focus-Blast",
				"Stone-Edge",
				"Grass-Knot",
				"Wide-Guard",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Chip-Away",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Timburr PokemonInstance Class
	#region Timburr
	public class TimburrInstance : PokemonInstance
	{
		#region Timburr Constructors
		/// <summary>
		/// Timburr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TimburrInstance(string nickname, int level)
		: base(
				SpeciesTimburr.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Timburr Builder only waiting for a Level
		/// </summary>
		public TimburrInstance(int level)
		: base(
				SpeciesTimburr.Instance, // PokemonInstance Species
				"Timburr", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Timburr Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TimburrInstance() : base(
			SpeciesTimburr.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}