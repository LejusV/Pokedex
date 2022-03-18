using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sawk Species to store common natural stats of all Sawks
	#region SpeciesSawk
	public class SpeciesSawk : PokemonSpecies
	{
#nullable enable
		private static SpeciesSawk? _instance = null;
#nullable restore
        public static SpeciesSawk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSawk();
                }
                return _instance;
            }
        }

		#region SpeciesSawk Constructor
		public SpeciesSawk() : base(
			539,
			"Sawk",
			1.4,
			51.0,
			75, // HPs
			125, 75, // Attack & Defense
			30, 75, // Special Attack & Defense
			85		
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
				"Karate-Chop",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Double-Kick",
				"Leer",
				"Low-Kick",
				"Counter",
				"Strength",
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
				"Reversal",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
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
				"Close-Combat",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Sawk PokemonInstance Class
	#region Sawk
	public class SawkInstance : PokemonInstance
	{
		#region Sawk Constructors
		/// <summary>
		/// Sawk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SawkInstance(string nickname, int level)
		: base(
				SpeciesSawk.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawk Builder only waiting for a Level
		/// </summary>
		public SawkInstance(int level)
		: base(
				SpeciesSawk.Instance, // PokemonInstance Species
				"Sawk", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawk Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SawkInstance() : base(
			SpeciesSawk.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}