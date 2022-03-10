using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shroomish Species to store common natural stats of all Shroomishs
	#region SpeciesShroomish
	public class SpeciesShroomish : PokemonSpecies
	{
#nullable enable
		private static SpeciesShroomish? _instance = null;
#nullable restore
        public static SpeciesShroomish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShroomish();
                }
                return _instance;
            }
        }

		#region SpeciesShroomish Constructor
		public SpeciesShroomish() : base(
			"Shroomish",
			0.4,
			4.5,
			60, // HPs
			40, 60, // Attack & Defense
			40, 60, // Special Attack & Defense
			35		
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
				"Swords-Dance",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Spore",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Charm",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Snatch",
				"Secret-Power",
				"Fake-Tears",
				"Bullet-Seed",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Shroomish PokemonInstance Class
	#region Shroomish
	public class ShroomishInstance : PokemonInstance
	{
		#region Shroomish Constructors
		/// <summary>
		/// Shroomish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShroomishInstance(string nickname, int level)
		: base(
				285,
				SpeciesShroomish.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shroomish Builder only waiting for a Level
		/// </summary>
		public ShroomishInstance(int level)
		: base(
				285,
				SpeciesShroomish.Instance, // PokemonInstance Species
				"Shroomish", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shroomish Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Shroomish() : base(
			285,
			SpeciesShroomish.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}