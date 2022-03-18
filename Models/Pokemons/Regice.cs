using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Regice Species to store common natural stats of all Regices
	#region SpeciesRegice
	public class SpeciesRegice : PokemonSpecies
	{
#nullable enable
		private static SpeciesRegice? _instance = null;
#nullable restore
        public static SpeciesRegice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRegice();
                }
                return _instance;
            }
        }

		#region SpeciesRegice Constructor
		public SpeciesRegice() : base(
			378,
			"Regice",
			1.8,
			175.0,
			80, // HPs
			50, 100, // Attack & Defense
			100, 200, // Special Attack & Defense
			50		
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
				"Ice-Punch",
				"Thunder-Punch",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Self-Destruct",
				"Amnesia",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Lock-On",
				"Endure",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Block",
				"Shock-Wave",
				"Gravity",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Rock-Polish",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Charge-Beam",
				"Round",
				"Bulldoze",
				"Frost-Breath",
				"Confide",
				"Power-Up-Punch",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion

	//Regice PokemonInstance Class
	#region Regice
	public class RegiceInstance : PokemonInstance
	{
		#region Regice Constructors
		/// <summary>
		/// Regice Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RegiceInstance(string nickname, int level)
		: base(
				SpeciesRegice.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regice Builder only waiting for a Level
		/// </summary>
		public RegiceInstance(int level)
		: base(
				SpeciesRegice.Instance, // PokemonInstance Species
				"Regice", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regice Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RegiceInstance() : base(
			SpeciesRegice.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}