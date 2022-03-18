using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Omastar Species to store common natural stats of all Omastars
	#region SpeciesOmastar
	public class SpeciesOmastar : PokemonSpecies
	{
#nullable enable
		private static SpeciesOmastar? _instance = null;
#nullable restore
        public static SpeciesOmastar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesOmastar();
                }
                return _instance;
            }
        }

		#region SpeciesOmastar Constructor
		public SpeciesOmastar() : base(
			139,
			"Omastar",
			1.0,
			35.0,
			70, // HPs
			60, 125, // Attack & Defense
			115, 70, // Special Attack & Defense
			55		
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
				"Bind",
				"Headbutt",
				"Horn-Attack",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Seismic-Toss",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Spike-Cannon",
				"Constrict",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Tickle",
				"Iron-Defense",
				"Mud-Shot",
				"Rock-Blast",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Rock-Polish",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Scald",
				"Shell-Smash",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Omastar PokemonInstance Class
	#region Omastar
	public class OmastarInstance : PokemonInstance
	{
		#region Omastar Constructors
		/// <summary>
		/// Omastar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public OmastarInstance(string nickname, int level)
		: base(
				SpeciesOmastar.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omastar Builder only waiting for a Level
		/// </summary>
		public OmastarInstance(int level)
		: base(
				SpeciesOmastar.Instance, // PokemonInstance Species
				"Omastar", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omastar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public OmastarInstance() : base(
			SpeciesOmastar.Instance, // PokemonInstance Species
			Rock.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}