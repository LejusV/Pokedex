using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gogoat Species to store common natural stats of all Gogoats
	#region SpeciesGogoat
	public class SpeciesGogoat : PokemonSpecies
	{
#nullable enable
		private static SpeciesGogoat? _instance = null;
#nullable restore
        public static SpeciesGogoat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGogoat();
                }
                return _instance;
            }
        }

		#region SpeciesGogoat Constructor
		public SpeciesGogoat() : base(
			673,
			"Gogoat",
			1.7,
			91.0,
			123, // HPs
			100, 62, // Attack & Defense
			97, 81, // Special Attack & Defense
			68		
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
				"Vine-Whip",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Roar",
				"Surf",
				"Hyper-Beam",
				"Strength",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Milk-Drink",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Aerial-Ace",
				"Bulk-Up",
				"Bounce",
				"Leaf-Blade",
				"Payback",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Grass-Knot",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Horn-Leech",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Gogoat PokemonInstance Class
	#region Gogoat
	public class GogoatInstance : PokemonInstance
	{
		#region Gogoat Constructors
		/// <summary>
		/// Gogoat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GogoatInstance(string nickname, int level)
		: base(
				SpeciesGogoat.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gogoat Builder only waiting for a Level
		/// </summary>
		public GogoatInstance(int level)
		: base(
				SpeciesGogoat.Instance, // PokemonInstance Species
				"Gogoat", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gogoat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GogoatInstance() : base(
			SpeciesGogoat.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}