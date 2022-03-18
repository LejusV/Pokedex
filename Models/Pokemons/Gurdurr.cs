using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gurdurr Species to store common natural stats of all Gurdurrs
	#region SpeciesGurdurr
	public class SpeciesGurdurr : PokemonSpecies
	{
#nullable enable
		private static SpeciesGurdurr? _instance = null;
#nullable restore
        public static SpeciesGurdurr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGurdurr();
                }
                return _instance;
            }
        }

		#region SpeciesGurdurr Constructor
		public SpeciesGurdurr() : base(
			533,
			"Gurdurr",
			1.2,
			40.0,
			85, // HPs
			105, 85, // Attack & Defense
			40, 50, // Special Attack & Defense
			40		
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
				"Low-Kick",
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
				"Stone-Edge",
				"Grass-Knot",
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

	//Gurdurr PokemonInstance Class
	#region Gurdurr
	public class GurdurrInstance : PokemonInstance
	{
		#region Gurdurr Constructors
		/// <summary>
		/// Gurdurr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GurdurrInstance(string nickname, int level)
		: base(
				SpeciesGurdurr.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gurdurr Builder only waiting for a Level
		/// </summary>
		public GurdurrInstance(int level)
		: base(
				SpeciesGurdurr.Instance, // PokemonInstance Species
				"Gurdurr", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gurdurr Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GurdurrInstance() : base(
			SpeciesGurdurr.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}