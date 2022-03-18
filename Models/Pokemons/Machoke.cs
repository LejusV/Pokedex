using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Machoke Species to store common natural stats of all Machokes
	#region SpeciesMachoke
	public class SpeciesMachoke : PokemonSpecies
	{
#nullable enable
		private static SpeciesMachoke? _instance = null;
#nullable restore
        public static SpeciesMachoke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMachoke();
                }
                return _instance;
            }
        }

		#region SpeciesMachoke Constructor
		public SpeciesMachoke() : base(
			67,
			"Machoke",
			1.5,
			70.5,
			80, // HPs
			100, 70, // Attack & Defense
			50, 60, // Special Attack & Defense
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
				"Karate-Chop",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
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
				"Vital-Throw",
				"Hidden-Power",
				"Cross-Chop",
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
				"Rock-Tomb",
				"Bulk-Up",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Rock-Climb",
				"Captivate",
				"Smack-Down",
				"Low-Sweep",
				"Round",
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

	//Machoke PokemonInstance Class
	#region Machoke
	public class MachokeInstance : PokemonInstance
	{
		#region Machoke Constructors
		/// <summary>
		/// Machoke Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MachokeInstance(string nickname, int level)
		: base(
				SpeciesMachoke.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machoke Builder only waiting for a Level
		/// </summary>
		public MachokeInstance(int level)
		: base(
				SpeciesMachoke.Instance, // PokemonInstance Species
				"Machoke", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machoke Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MachokeInstance() : base(
			SpeciesMachoke.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}