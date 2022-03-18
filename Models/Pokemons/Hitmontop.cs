using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hitmontop Species to store common natural stats of all Hitmontops
	#region SpeciesHitmontop
	public class SpeciesHitmontop : PokemonSpecies
	{
#nullable enable
		private static SpeciesHitmontop? _instance = null;
#nullable restore
        public static SpeciesHitmontop Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHitmontop();
                }
                return _instance;
            }
        }

		#region SpeciesHitmontop Constructor
		public SpeciesHitmontop() : base(
			237,
			"Hitmontop",
			1.4,
			48.0,
			50, // HPs
			95, 95, // Attack & Defense
			35, 110, // Special Attack & Defense
			70		
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
				"Mega-Kick",
				"Rolling-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Triple-Kick",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Rapid-Spin",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Helping-Hand",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Gyro-Ball",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Sucker-Punch",
				"Vacuum-Wave",
				"Stone-Edge",
				"Captivate",
				"Wide-Guard",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Hitmontop PokemonInstance Class
	#region Hitmontop
	public class HitmontopInstance : PokemonInstance
	{
		#region Hitmontop Constructors
		/// <summary>
		/// Hitmontop Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HitmontopInstance(string nickname, int level)
		: base(
				SpeciesHitmontop.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmontop Builder only waiting for a Level
		/// </summary>
		public HitmontopInstance(int level)
		: base(
				SpeciesHitmontop.Instance, // PokemonInstance Species
				"Hitmontop", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmontop Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HitmontopInstance() : base(
			SpeciesHitmontop.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}