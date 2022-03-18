using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Torkoal Species to store common natural stats of all Torkoals
	#region SpeciesTorkoal
	public class SpeciesTorkoal : PokemonSpecies
	{
#nullable enable
		private static SpeciesTorkoal? _instance = null;
#nullable restore
        public static SpeciesTorkoal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTorkoal();
                }
                return _instance;
            }
        }

		#region SpeciesTorkoal Constructor
		public SpeciesTorkoal() : base(
			324,
			"Torkoal",
			0.5,
			80.4,
			70, // HPs
			85, 140, // Attack & Defense
			85, 70, // Special Attack & Defense
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Withdraw",
				"Self-Destruct",
				"Smog",
				"Fire-Blast",
				"Skull-Bash",
				"Amnesia",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Superpower",
				"Yawn",
				"Eruption",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Iron-Defense",
				"Gyro-Ball",
				"Natural-Gift",
				"Earth-Power",
				"Giga-Impact",
				"Lava-Plume",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Flame-Burst",
				"Flame-Charge",
				"After-You",
				"Round",
				"Clear-Smog",
				"Shell-Smash",
				"Incinerate",
				"Inferno",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Torkoal PokemonInstance Class
	#region Torkoal
	public class TorkoalInstance : PokemonInstance
	{
		#region Torkoal Constructors
		/// <summary>
		/// Torkoal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TorkoalInstance(string nickname, int level)
		: base(
				SpeciesTorkoal.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torkoal Builder only waiting for a Level
		/// </summary>
		public TorkoalInstance(int level)
		: base(
				SpeciesTorkoal.Instance, // PokemonInstance Species
				"Torkoal", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torkoal Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TorkoalInstance() : base(
			SpeciesTorkoal.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}