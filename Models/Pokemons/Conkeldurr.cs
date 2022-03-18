using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Conkeldurr Species to store common natural stats of all Conkeldurrs
	#region SpeciesConkeldurr
	public class SpeciesConkeldurr : PokemonSpecies
	{
#nullable enable
		private static SpeciesConkeldurr? _instance = null;
#nullable restore
        public static SpeciesConkeldurr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesConkeldurr();
                }
                return _instance;
            }
        }

		#region SpeciesConkeldurr Constructor
		public SpeciesConkeldurr() : base(
			534,
			"Conkeldurr",
			1.4,
			87.0,
			105, // HPs
			140, 95, // Attack & Defense
			55, 65, // Special Attack & Defense
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
				"Pound",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Leer",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
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
				"Poison-Jab",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Stone-Edge",
				"Grass-Knot",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Chip-Away",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Conkeldurr PokemonInstance Class
	#region Conkeldurr
	public class ConkeldurrInstance : PokemonInstance
	{
		#region Conkeldurr Constructors
		/// <summary>
		/// Conkeldurr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ConkeldurrInstance(string nickname, int level)
		: base(
				SpeciesConkeldurr.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Conkeldurr Builder only waiting for a Level
		/// </summary>
		public ConkeldurrInstance(int level)
		: base(
				SpeciesConkeldurr.Instance, // PokemonInstance Species
				"Conkeldurr", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Conkeldurr Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ConkeldurrInstance() : base(
			SpeciesConkeldurr.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}