using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Yanma Species to store common natural stats of all Yanmas
	#region SpeciesYanma
	public class SpeciesYanma : PokemonSpecies
	{
#nullable enable
		private static SpeciesYanma? _instance = null;
#nullable restore
        public static SpeciesYanma Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesYanma();
                }
                return _instance;
            }
        }

		#region SpeciesYanma Constructor
		public SpeciesYanma() : base(
			"Yanma",
			1.2,
			38.0,
			65, // HPs
			65, 45, // Attack & Defense
			75, 45, // Special Attack & Defense
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
				"Wing-Attack",
				"Whirlwind",
				"Headbutt",
				"Tackle",
				"Double-Edge",
				"Supersonic",
				"Sonic-Boom",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Leech-Life",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Feint-Attack",
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
				"Air-Slash",
				"Bug-Buzz",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Round",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Yanma PokemonInstance Class
	#region Yanma
	public class YanmaInstance : PokemonInstance
	{
		#region Yanma Constructors
		/// <summary>
		/// Yanma Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public YanmaInstance(string nickname, int level)
		: base(
				193,
				SpeciesYanma.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanma Builder only waiting for a Level
		/// </summary>
		public YanmaInstance(int level)
		: base(
				193,
				SpeciesYanma.Instance, // PokemonInstance Species
				"Yanma", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanma Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Yanma() : base(
			193,
			SpeciesYanma.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}