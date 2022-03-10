using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Yanmega Species to store common natural stats of all Yanmegas
	#region SpeciesYanmega
	public class SpeciesYanmega : PokemonSpecies
	{
#nullable enable
		private static SpeciesYanmega? _instance = null;
#nullable restore
        public static SpeciesYanmega Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesYanmega();
                }
                return _instance;
            }
        }

		#region SpeciesYanmega Constructor
		public SpeciesYanmega() : base(
			"Yanmega",
			1.9,
			51.5,
			86, // HPs
			76, 86, // Attack & Defense
			116, 56, // Special Attack & Defense
			95		
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
				"Tackle",
				"Supersonic",
				"Sonic-Boom",
				"Hyper-Beam",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Leech-Life",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Night-Slash",
				"Air-Slash",
				"Bug-Buzz",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Round",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Yanmega PokemonInstance Class
	#region Yanmega
	public class YanmegaInstance : PokemonInstance
	{
		#region Yanmega Constructors
		/// <summary>
		/// Yanmega Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public YanmegaInstance(string nickname, int level)
		: base(
				469,
				SpeciesYanmega.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanmega Builder only waiting for a Level
		/// </summary>
		public YanmegaInstance(int level)
		: base(
				469,
				SpeciesYanmega.Instance, // PokemonInstance Species
				"Yanmega", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanmega Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Yanmega() : base(
			469,
			SpeciesYanmega.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}