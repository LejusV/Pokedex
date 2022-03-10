using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Makuhita Species to store common natural stats of all Makuhitas
	#region SpeciesMakuhita
	public class SpeciesMakuhita : PokemonSpecies
	{
#nullable enable
		private static SpeciesMakuhita? _instance = null;
#nullable restore
        public static SpeciesMakuhita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMakuhita();
                }
                return _instance;
            }
        }

		#region SpeciesMakuhita Constructor
		public SpeciesMakuhita() : base(
			"Makuhita",
			1.0,
			86.4,
			72, // HPs
			60, 30, // Attack & Defense
			20, 30, // Special Attack & Defense
			25		
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
				"Feint-Attack",
				"Belly-Drum",
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
				"Whirlpool",
				"Fake-Out",
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
				"Arm-Thrust",
				"Rock-Tomb",
				"Bulk-Up",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Force-Palm",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Bullet-Punch",
				"Rock-Climb",
				"Captivate",
				"Wide-Guard",
				"Smack-Down",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
				"Chip-Away",
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

	//Makuhita PokemonInstance Class
	#region Makuhita
	public class MakuhitaInstance : PokemonInstance
	{
		#region Makuhita Constructors
		/// <summary>
		/// Makuhita Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MakuhitaInstance(string nickname, int level)
		: base(
				296,
				SpeciesMakuhita.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Makuhita Builder only waiting for a Level
		/// </summary>
		public MakuhitaInstance(int level)
		: base(
				296,
				SpeciesMakuhita.Instance, // PokemonInstance Species
				"Makuhita", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Makuhita Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Makuhita() : base(
			296,
			SpeciesMakuhita.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}