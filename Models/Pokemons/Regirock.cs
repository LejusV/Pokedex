using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Regirock Species to store common natural stats of all Regirocks
	#region SpeciesRegirock
	public class SpeciesRegirock : PokemonSpecies
	{
#nullable enable
		private static SpeciesRegirock? _instance = null;
#nullable restore
        public static SpeciesRegirock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRegirock();
                }
                return _instance;
            }
        }

		#region SpeciesRegirock Constructor
		public SpeciesRegirock() : base(
			377,
			"Regirock",
			1.7,
			230.0,
			80, // HPs
			100, 200, // Attack & Defense
			50, 100, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Self-Destruct",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Lock-On",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Shock-Wave",
				"Gravity",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Rock-Polish",
				"Drain-Punch",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Charge-Beam",
				"Smack-Down",
				"Round",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Regirock PokemonInstance Class
	#region Regirock
	public class RegirockInstance : PokemonInstance
	{
		#region Regirock Constructors
		/// <summary>
		/// Regirock Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RegirockInstance(string nickname, int level)
		: base(
				SpeciesRegirock.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regirock Builder only waiting for a Level
		/// </summary>
		public RegirockInstance(int level)
		: base(
				SpeciesRegirock.Instance, // PokemonInstance Species
				"Regirock", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regirock Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RegirockInstance() : base(
			SpeciesRegirock.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}