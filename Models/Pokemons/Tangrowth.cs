using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tangrowth Species to store common natural stats of all Tangrowths
	#region SpeciesTangrowth
	public class SpeciesTangrowth : PokemonSpecies
	{
#nullable enable
		private static SpeciesTangrowth? _instance = null;
#nullable restore
        public static SpeciesTangrowth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTangrowth();
                }
                return _instance;
            }
        }

		#region SpeciesTangrowth Constructor
		public SpeciesTangrowth() : base(
			465,
			"Tangrowth",
			2.0,
			128.6,
			100, // HPs
			100, 125, // Attack & Defense
			110, 50, // Special Attack & Defense
			50		
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
				"Cut",
				"Bind",
				"Slam",
				"Vine-Whip",
				"Headbutt",
				"Hyper-Beam",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Constrict",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Tickle",
				"Bullet-Seed",
				"Aerial-Ace",
				"Block",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Wring-Out",
				"Worry-Seed",
				"Poison-Jab",
				"Seed-Bomb",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Bulldoze",
				"Grassy-Terrain",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Tangrowth PokemonInstance Class
	#region Tangrowth
	public class TangrowthInstance : PokemonInstance
	{
		#region Tangrowth Constructors
		/// <summary>
		/// Tangrowth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TangrowthInstance(string nickname, int level)
		: base(
				SpeciesTangrowth.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangrowth Builder only waiting for a Level
		/// </summary>
		public TangrowthInstance(int level)
		: base(
				SpeciesTangrowth.Instance, // PokemonInstance Species
				"Tangrowth", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangrowth Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TangrowthInstance() : base(
			SpeciesTangrowth.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}