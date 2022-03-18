using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hariyama Species to store common natural stats of all Hariyamas
	#region SpeciesHariyama
	public class SpeciesHariyama : PokemonSpecies
	{
#nullable enable
		private static SpeciesHariyama? _instance = null;
#nullable restore
        public static SpeciesHariyama Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHariyama();
                }
                return _instance;
            }
        }

		#region SpeciesHariyama Constructor
		public SpeciesHariyama() : base(
			297,
			"Hariyama",
			2.3,
			253.8,
			144, // HPs
			120, 60, // Attack & Defense
			40, 60, // Special Attack & Defense
			50		
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
				"Whirlwind",
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Surf",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Metronome",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Whirlpool",
				"Fake-Out",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Helping-Hand",
				"Role-Play",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Arm-Thrust",
				"Rock-Tomb",
				"Bulk-Up",
				"Wake-Up-Slap",
				"Brine",
				"Natural-Gift",
				"Close-Combat",
				"Payback",
				"Fling",
				"Force-Palm",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Smack-Down",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Hariyama PokemonInstance Class
	#region Hariyama
	public class HariyamaInstance : PokemonInstance
	{
		#region Hariyama Constructors
		/// <summary>
		/// Hariyama Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HariyamaInstance(string nickname, int level)
		: base(
				SpeciesHariyama.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hariyama Builder only waiting for a Level
		/// </summary>
		public HariyamaInstance(int level)
		: base(
				SpeciesHariyama.Instance, // PokemonInstance Species
				"Hariyama", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hariyama Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HariyamaInstance() : base(
			SpeciesHariyama.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}