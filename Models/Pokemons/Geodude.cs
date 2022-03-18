using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Geodude Species to store common natural stats of all Geodudes
	#region SpeciesGeodude
	public class SpeciesGeodude : PokemonSpecies
	{
#nullable enable
		private static SpeciesGeodude? _instance = null;
#nullable restore
        public static SpeciesGeodude Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGeodude();
                }
                return _instance;
            }
        }

		#region SpeciesGeodude Constructor
		public SpeciesGeodude() : base(
			74,
			"Geodude",
			0.4,
			20.0,
			40, // HPs
			80, 100, // Attack & Defense
			30, 30, // Special Attack & Defense
			20		
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
				"Thunder-Punch",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Flamethrower",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Bide",
				"Metronome",
				"Self-Destruct",
				"Fire-Blast",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Mud-Sport",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Hammer-Arm",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Sucker-Punch",
				"Rock-Polish",
				"Earth-Power",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Wide-Guard",
				"Autotomize",
				"Smack-Down",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Geodude PokemonInstance Class
	#region Geodude
	public class GeodudeInstance : PokemonInstance
	{
		#region Geodude Constructors
		/// <summary>
		/// Geodude Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GeodudeInstance(string nickname, int level)
		: base(
				SpeciesGeodude.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Geodude Builder only waiting for a Level
		/// </summary>
		public GeodudeInstance(int level)
		: base(
				SpeciesGeodude.Instance, // PokemonInstance Species
				"Geodude", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Geodude Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GeodudeInstance() : base(
			SpeciesGeodude.Instance, // PokemonInstance Species
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}