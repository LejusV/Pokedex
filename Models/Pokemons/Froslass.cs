using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Froslass Species to store common natural stats of all Froslasss
	#region SpeciesFroslass
	public class SpeciesFroslass : PokemonSpecies
	{
#nullable enable
		private static SpeciesFroslass? _instance = null;
#nullable restore
        public static SpeciesFroslass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFroslass();
                }
                return _instance;
            }
        }

		#region SpeciesFroslass Constructor
		public SpeciesFroslass() : base(
			478,
			"Froslass",
			1.3,
			26.6,
			70, // HPs
			80, 70, // Attack & Defense
			80, 70, // Special Attack & Defense
			110		
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
				"Ice-Punch",
				"Headbutt",
				"Leer",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Spite",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Hail",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Signal-Beam",
				"Block",
				"Shock-Wave",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Captivate",
				"Ominous-Wind",
				"Telekinesis",
				"Round",
				"Frost-Breath",
				"Draining-Kiss",
				"Confide",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion

	//Froslass PokemonInstance Class
	#region Froslass
	public class FroslassInstance : PokemonInstance
	{
		#region Froslass Constructors
		/// <summary>
		/// Froslass Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FroslassInstance(string nickname, int level)
		: base(
				SpeciesFroslass.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froslass Builder only waiting for a Level
		/// </summary>
		public FroslassInstance(int level)
		: base(
				SpeciesFroslass.Instance, // PokemonInstance Species
				"Froslass", level,
				Ice.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froslass Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public FroslassInstance() : base(
			SpeciesFroslass.Instance, // PokemonInstance Species
			Ice.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}