using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Poliwrath Species to store common natural stats of all Poliwraths
	#region SpeciesPoliwrath
	public class SpeciesPoliwrath : PokemonSpecies
	{
#nullable enable
		private static SpeciesPoliwrath? _instance = null;
#nullable restore
        public static SpeciesPoliwrath Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPoliwrath();
                }
                return _instance;
            }
        }

		#region SpeciesPoliwrath Constructor
		public SpeciesPoliwrath() : base(
			62,
			"Poliwrath",
			1.3,
			54.0,
			90, // HPs
			95, 95, // Attack & Defense
			70, 90, // Special Attack & Defense
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
				"Double-Slap",
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Metronome",
				"Waterfall",
				"Skull-Bash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
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
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Bulk-Up",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Captivate",
				"Low-Sweep",
				"Round",
				"Scald",
				"Circle-Throw",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Poliwrath PokemonInstance Class
	#region Poliwrath
	public class PoliwrathInstance : PokemonInstance
	{
		#region Poliwrath Constructors
		/// <summary>
		/// Poliwrath Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PoliwrathInstance(string nickname, int level)
		: base(
				SpeciesPoliwrath.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwrath Builder only waiting for a Level
		/// </summary>
		public PoliwrathInstance(int level)
		: base(
				SpeciesPoliwrath.Instance, // PokemonInstance Species
				"Poliwrath", level,
				Water.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwrath Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PoliwrathInstance() : base(
			SpeciesPoliwrath.Instance, // PokemonInstance Species
			Water.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}