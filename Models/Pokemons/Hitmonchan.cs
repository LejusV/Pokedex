using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hitmonchan Species to store common natural stats of all Hitmonchans
	#region SpeciesHitmonchan
	public class SpeciesHitmonchan : PokemonSpecies
	{
#nullable enable
		private static SpeciesHitmonchan? _instance = null;
#nullable restore
        public static SpeciesHitmonchan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHitmonchan();
                }
                return _instance;
            }
        }

		#region SpeciesHitmonchan Constructor
		public SpeciesHitmonchan() : base(
			107,
			"Hitmonchan",
			1.4,
			50.2,
			50, // HPs
			105, 79, // Attack & Defense
			35, 110, // Special Attack & Defense
			76		
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
				"Comet-Punch",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Metronome",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mach-Punch",
				"Mud-Slap",
				"Detect",
				"Endure",
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
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Bullet-Punch",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
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

	//Hitmonchan PokemonInstance Class
	#region Hitmonchan
	public class HitmonchanInstance : PokemonInstance
	{
		#region Hitmonchan Constructors
		/// <summary>
		/// Hitmonchan Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HitmonchanInstance(string nickname, int level)
		: base(
				SpeciesHitmonchan.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonchan Builder only waiting for a Level
		/// </summary>
		public HitmonchanInstance(int level)
		: base(
				SpeciesHitmonchan.Instance, // PokemonInstance Species
				"Hitmonchan", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonchan Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HitmonchanInstance() : base(
			SpeciesHitmonchan.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}