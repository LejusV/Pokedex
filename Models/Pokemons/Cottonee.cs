using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cottonee Species to store common natural stats of all Cottonees
	#region SpeciesCottonee
	public class SpeciesCottonee : PokemonSpecies
	{
#nullable enable
		private static SpeciesCottonee? _instance = null;
#nullable restore
        public static SpeciesCottonee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCottonee();
                }
                return _instance;
            }
        }

		#region SpeciesCottonee Constructor
		public SpeciesCottonee() : base(
			546,
			"Cottonee",
			0.3,
			0.6,
			40, // HPs
			27, 60, // Attack & Defense
			37, 50, // Special Attack & Defense
			66		
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
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Toxic",
				"Double-Team",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Giga-Drain",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Hidden-Power",
				"Sunny-Day",
				"Beat-Up",
				"Memento",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Fake-Tears",
				"Grass-Whistle",
				"Tickle",
				"Covet",
				"Natural-Gift",
				"Tailwind",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Switcheroo",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Cotton-Guard",
				"Misty-Terrain",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Cottonee PokemonInstance Class
	#region Cottonee
	public class CottoneeInstance : PokemonInstance
	{
		#region Cottonee Constructors
		/// <summary>
		/// Cottonee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CottoneeInstance(string nickname, int level)
		: base(
				SpeciesCottonee.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cottonee Builder only waiting for a Level
		/// </summary>
		public CottoneeInstance(int level)
		: base(
				SpeciesCottonee.Instance, // PokemonInstance Species
				"Cottonee", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cottonee Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CottoneeInstance() : base(
			SpeciesCottonee.Instance, // PokemonInstance Species
			Grass.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}