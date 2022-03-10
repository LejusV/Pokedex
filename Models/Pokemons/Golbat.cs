using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Golbat Species to store common natural stats of all Golbats
	#region SpeciesGolbat
	public class SpeciesGolbat : PokemonSpecies
	{
#nullable enable
		private static SpeciesGolbat? _instance = null;
#nullable restore
        public static SpeciesGolbat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGolbat();
                }
                return _instance;
            }
        }

		#region SpeciesGolbat Constructor
		public SpeciesGolbat() : base(
			"Golbat",
			1.6,
			55.0,
			75, // HPs
			80, 70, // Attack & Defense
			65, 75, // Special Attack & Defense
			90		
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
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Supersonic",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
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
				"Air-Slash",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
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

	//Golbat PokemonInstance Class
	#region Golbat
	public class GolbatInstance : PokemonInstance
	{
		#region Golbat Constructors
		/// <summary>
		/// Golbat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GolbatInstance(string nickname, int level)
		: base(
				42,
				SpeciesGolbat.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golbat Builder only waiting for a Level
		/// </summary>
		public GolbatInstance(int level)
		: base(
				42,
				SpeciesGolbat.Instance, // PokemonInstance Species
				"Golbat", level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golbat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Golbat() : base(
			42,
			SpeciesGolbat.Instance, // PokemonInstance Species
			Poison.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}