using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Passimian Species to store common natural stats of all Passimians
	#region SpeciesPassimian
	public class SpeciesPassimian : PokemonSpecies
	{
#nullable enable
		private static SpeciesPassimian? _instance = null;
#nullable restore
        public static SpeciesPassimian Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPassimian();
                }
                return _instance;
            }
        }

		#region SpeciesPassimian Constructor
		public SpeciesPassimian() : base(
			"Passimian",
			2.0,
			82.8,
			100, // HPs
			120, 90, // Attack & Defense
			40, 60, // Special Attack & Defense
			80		
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
				"Tackle",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Seismic-Toss",
				"Earthquake",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Focus-Energy",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Reversal",
				"Protect",
				"Scary-Face",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Beat-Up",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Gyro-Ball",
				"Feint",
				"U-Turn",
				"Close-Combat",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Iron-Head",
				"Grass-Knot",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Bestow",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Passimian PokemonInstance Class
	#region Passimian
	public class PassimianInstance : PokemonInstance
	{
		#region Passimian Constructors
		/// <summary>
		/// Passimian Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PassimianInstance(string nickname, int level)
		: base(
				766,
				SpeciesPassimian.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Passimian Builder only waiting for a Level
		/// </summary>
		public PassimianInstance(int level)
		: base(
				766,
				SpeciesPassimian.Instance, // PokemonInstance Species
				"Passimian", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Passimian Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Passimian() : base(
			766,
			SpeciesPassimian.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}