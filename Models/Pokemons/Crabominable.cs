using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Crabominable Species to store common natural stats of all Crabominables
	#region SpeciesCrabominable
	public class SpeciesCrabominable : PokemonSpecies
	{
#nullable enable
		private static SpeciesCrabominable? _instance = null;
#nullable restore
        public static SpeciesCrabominable Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCrabominable();
                }
                return _instance;
            }
        }

		#region SpeciesCrabominable Constructor
		public SpeciesCrabominable() : base(
			740,
			"Crabominable",
			1.7,
			180.0,
			97, // HPs
			132, 77, // Attack & Defense
			62, 67, // Special Attack & Defense
			43		
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
				"Ice-Punch",
				"Leer",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bubble",
				"Dizzy-Punch",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Reversal",
				"Protect",
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
				"Rock-Smash",
				"Hail",
				"Facade",
				"Brick-Break",
				"Rock-Tomb",
				"Iron-Defense",
				"Bulk-Up",
				"Close-Combat",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Stone-Edge",
				"Round",
				"Scald",
				"Bulldoze",
				"Frost-Breath",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Ice-Hammer",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Crabominable PokemonInstance Class
	#region Crabominable
	public class CrabominableInstance : PokemonInstance
	{
		#region Crabominable Constructors
		/// <summary>
		/// Crabominable Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CrabominableInstance(string nickname, int level)
		: base(
				SpeciesCrabominable.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabominable Builder only waiting for a Level
		/// </summary>
		public CrabominableInstance(int level)
		: base(
				SpeciesCrabominable.Instance, // PokemonInstance Species
				"Crabominable", level,
				Fighting.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabominable Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CrabominableInstance() : base(
			SpeciesCrabominable.Instance, // PokemonInstance Species
			Fighting.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}