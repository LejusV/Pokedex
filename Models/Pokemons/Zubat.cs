using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zubat Species to store common natural stats of all Zubats
	#region SpeciesZubat
	public class SpeciesZubat : PokemonSpecies
	{
#nullable enable
		private static SpeciesZubat? _instance = null;
#nullable restore
        public static SpeciesZubat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZubat();
                }
                return _instance;
            }
        }

		#region SpeciesZubat Constructor
		public SpeciesZubat() : base(
			41,
			"Zubat",
			0.8,
			7.5,
			40, // HPs
			45, 35, // Attack & Defense
			30, 40, // Special Attack & Defense
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
				"Razor-Wind",
				"Gust",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Supersonic",
				"Absorb",
				"Mega-Drain",
				"Toxic",
				"Hypnosis",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Bide",
				"Swift",
				"Leech-Life",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
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
				"Pursuit",
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
				"Air-Slash",
				"Brave-Bird",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Venoshock",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion

	//Zubat PokemonInstance Class
	#region Zubat
	public class ZubatInstance : PokemonInstance
	{
		#region Zubat Constructors
		/// <summary>
		/// Zubat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZubatInstance(string nickname, int level)
		: base(
				SpeciesZubat.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zubat Builder only waiting for a Level
		/// </summary>
		public ZubatInstance(int level)
		: base(
				SpeciesZubat.Instance, // PokemonInstance Species
				"Zubat", level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zubat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ZubatInstance() : base(
			SpeciesZubat.Instance, // PokemonInstance Species
			Poison.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}