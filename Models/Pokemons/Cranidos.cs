using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cranidos Species to store common natural stats of all Cranidoss
	#region SpeciesCranidos
	public class SpeciesCranidos : PokemonSpecies
	{
#nullable enable
		private static SpeciesCranidos? _instance = null;
#nullable restore
        public static SpeciesCranidos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCranidos();
                }
                return _instance;
            }
        }

		#region SpeciesCranidos Constructor
		public SpeciesCranidos() : base(
			408,
			"Cranidos",
			0.9,
			31.5,
			67, // HPs
			125, 40, // Attack & Defense
			30, 30, // Special Attack & Defense
			58		
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
				"Fire-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Whirlwind",
				"Slam",
				"Stomp",
				"Headbutt",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Shock-Wave",
				"Hammer-Arm",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Fling",
				"Rock-Polish",
				"Dragon-Pulse",
				"Earth-Power",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Cranidos PokemonInstance Class
	#region Cranidos
	public class CranidosInstance : PokemonInstance
	{
		#region Cranidos Constructors
		/// <summary>
		/// Cranidos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CranidosInstance(string nickname, int level)
		: base(
				SpeciesCranidos.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cranidos Builder only waiting for a Level
		/// </summary>
		public CranidosInstance(int level)
		: base(
				SpeciesCranidos.Instance, // PokemonInstance Species
				"Cranidos", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cranidos Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CranidosInstance() : base(
			SpeciesCranidos.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}