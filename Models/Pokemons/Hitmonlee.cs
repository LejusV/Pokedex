using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hitmonlee Species to store common natural stats of all Hitmonlees
	#region SpeciesHitmonlee
	public class SpeciesHitmonlee : PokemonSpecies
	{
#nullable enable
		private static SpeciesHitmonlee? _instance = null;
#nullable restore
        public static SpeciesHitmonlee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHitmonlee();
                }
                return _instance;
            }
        }

		#region SpeciesHitmonlee Constructor
		public SpeciesHitmonlee() : base(
			106,
			"Hitmonlee",
			1.5,
			49.8,
			50, // HPs
			120, 53, // Attack & Defense
			35, 110, // Special Attack & Defense
			87		
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
				"Double-Kick",
				"Mega-Kick",
				"Jump-Kick",
				"Rolling-Kick",
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
				"Meditate",
				"Rage",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Metronome",
				"Swift",
				"Skull-Bash",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
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
				"Helping-Hand",
				"Role-Play",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Blaze-Kick",
				"Rock-Tomb",
				"Bulk-Up",
				"Bounce",
				"Covet",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Sucker-Punch",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Wide-Guard",
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

	//Hitmonlee PokemonInstance Class
	#region Hitmonlee
	public class HitmonleeInstance : PokemonInstance
	{
		#region Hitmonlee Constructors
		/// <summary>
		/// Hitmonlee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HitmonleeInstance(string nickname, int level)
		: base(
				SpeciesHitmonlee.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonlee Builder only waiting for a Level
		/// </summary>
		public HitmonleeInstance(int level)
		: base(
				SpeciesHitmonlee.Instance, // PokemonInstance Species
				"Hitmonlee", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonlee Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HitmonleeInstance() : base(
			SpeciesHitmonlee.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}