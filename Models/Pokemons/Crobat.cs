using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Crobat Species to store common natural stats of all Crobats
	#region SpeciesCrobat
	public class SpeciesCrobat : PokemonSpecies
	{
#nullable enable
		private static SpeciesCrobat? _instance = null;
#nullable restore
        public static SpeciesCrobat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCrobat();
                }
                return _instance;
            }
        }

		#region SpeciesCrobat Constructor
		public SpeciesCrobat() : base(
			"Crobat",
			1.8,
			75.0,
			85, // HPs
			90, 80, // Attack & Defense
			70, 80, // Special Attack & Defense
			130		
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
				"Fly",
				"Double-Edge",
				"Bite",
				"Supersonic",
				"Hyper-Beam",
				"Absorb",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Swift",
				"Leech-Life",
				"Sky-Attack",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Poison-Fang",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Dark-Pulse",
				"Air-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Cross-Poison",
				"Captivate",
				"Ominous-Wind",
				"Venoshock",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Crobat PokemonInstance Class
	#region Crobat
	public class CrobatInstance : PokemonInstance
	{
		#region Crobat Constructors
		/// <summary>
		/// Crobat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CrobatInstance(string nickname, int level)
		: base(
				169,
				SpeciesCrobat.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crobat Builder only waiting for a Level
		/// </summary>
		public CrobatInstance(int level)
		: base(
				169,
				SpeciesCrobat.Instance, // PokemonInstance Species
				"Crobat", level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crobat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Crobat() : base(
			169,
			SpeciesCrobat.Instance, // PokemonInstance Species
			Poison.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}