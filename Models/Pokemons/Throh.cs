using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Throh Species to store common natural stats of all Throhs
	#region SpeciesThroh
	public class SpeciesThroh : PokemonSpecies
	{
#nullable enable
		private static SpeciesThroh? _instance = null;
#nullable restore
        public static SpeciesThroh Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesThroh();
                }
                return _instance;
            }
        }

		#region SpeciesThroh Constructor
		public SpeciesThroh() : base(
			"Throh",
			1.3,
			55.5,
			120, // HPs
			100, 85, // Attack & Defense
			30, 85, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Bind",
				"Body-Slam",
				"Leer",
				"Low-Kick",
				"Seismic-Toss",
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
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Bulk-Up",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Wide-Guard",
				"Storm-Throw",
				"Low-Sweep",
				"Round",
				"Circle-Throw",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Mat-Block",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Throh PokemonInstance Class
	#region Throh
	public class ThrohInstance : PokemonInstance
	{
		#region Throh Constructors
		/// <summary>
		/// Throh Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ThrohInstance(string nickname, int level)
		: base(
				538,
				SpeciesThroh.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Throh Builder only waiting for a Level
		/// </summary>
		public ThrohInstance(int level)
		: base(
				538,
				SpeciesThroh.Instance, // PokemonInstance Species
				"Throh", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Throh Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Throh() : base(
			538,
			SpeciesThroh.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}