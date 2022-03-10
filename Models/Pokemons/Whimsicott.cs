using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Whimsicott Species to store common natural stats of all Whimsicotts
	#region SpeciesWhimsicott
	public class SpeciesWhimsicott : PokemonSpecies
	{
#nullable enable
		private static SpeciesWhimsicott? _instance = null;
#nullable restore
        public static SpeciesWhimsicott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWhimsicott();
                }
                return _instance;
            }
        }

		#region SpeciesWhimsicott Constructor
		public SpeciesWhimsicott() : base(
			"Whimsicott",
			0.7,
			6.6,
			60, // HPs
			67, 85, // Attack & Defense
			77, 75, // Special Attack & Defense
			116		
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
				"Gust",
				"Hyper-Beam",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Covet",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Trick-Room",
				"Grass-Knot",
				"Round",
				"Hurricane",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Whimsicott PokemonInstance Class
	#region Whimsicott
	public class WhimsicottInstance : PokemonInstance
	{
		#region Whimsicott Constructors
		/// <summary>
		/// Whimsicott Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WhimsicottInstance(string nickname, int level)
		: base(
				547,
				SpeciesWhimsicott.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whimsicott Builder only waiting for a Level
		/// </summary>
		public WhimsicottInstance(int level)
		: base(
				547,
				SpeciesWhimsicott.Instance, // PokemonInstance Species
				"Whimsicott", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whimsicott Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Whimsicott() : base(
			547,
			SpeciesWhimsicott.Instance, // PokemonInstance Species
			Grass.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}