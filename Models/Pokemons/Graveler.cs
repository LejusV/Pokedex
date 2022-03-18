using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Graveler Species to store common natural stats of all Gravelers
	#region SpeciesGraveler
	public class SpeciesGraveler : PokemonSpecies
	{
#nullable enable
		private static SpeciesGraveler? _instance = null;
#nullable restore
        public static SpeciesGraveler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGraveler();
                }
                return _instance;
            }
        }

		#region SpeciesGraveler Constructor
		public SpeciesGraveler() : base(
			75,
			"Graveler",
			1.0,
			105.0,
			55, // HPs
			95, 115, // Attack & Defense
			45, 45, // Special Attack & Defense
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

	//Graveler PokemonInstance Class
	#region Graveler
	public class GravelerInstance : PokemonInstance
	{
		#region Graveler Constructors
		/// <summary>
		/// Graveler Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GravelerInstance(string nickname, int level)
		: base(
				SpeciesGraveler.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Graveler Builder only waiting for a Level
		/// </summary>
		public GravelerInstance(int level)
		: base(
				SpeciesGraveler.Instance, // PokemonInstance Species
				"Graveler", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Graveler Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GravelerInstance() : base(
			SpeciesGraveler.Instance, // PokemonInstance Species
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}