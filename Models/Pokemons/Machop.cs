using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Machop Species to store common natural stats of all Machops
	#region SpeciesMachop
	public class SpeciesMachop : PokemonSpecies
	{
#nullable enable
		private static SpeciesMachop? _instance = null;
#nullable restore
        public static SpeciesMachop Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMachop();
                }
                return _instance;
            }
        }

		#region SpeciesMachop Constructor
		public SpeciesMachop() : base(
			66,
			"Machop",
			0.8,
			19.5,
			70, // HPs
			80, 50, // Attack & Defense
			35, 35, // Special Attack & Defense
			35		
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Rolling-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Flamethrower",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Meditate",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Focus-Energy",
				"Bide",
				"Metronome",
				"Fire-Blast",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
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
				"Encore",
				"Vital-Throw",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Helping-Hand",
				"Role-Play",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Tickle",
				"Bulk-Up",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Close-Combat",
				"Payback",
				"Fling",
				"Power-Trick",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Bullet-Punch",
				"Rock-Climb",
				"Captivate",
				"Smack-Down",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Incinerate",
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

	//Machop PokemonInstance Class
	#region Machop
	public class MachopInstance : PokemonInstance
	{
		#region Machop Constructors
		/// <summary>
		/// Machop Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MachopInstance(string nickname, int level)
		: base(
				SpeciesMachop.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machop Builder only waiting for a Level
		/// </summary>
		public MachopInstance(int level)
		: base(
				SpeciesMachop.Instance, // PokemonInstance Species
				"Machop", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machop Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MachopInstance() : base(
			SpeciesMachop.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}