using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Servine Species to store common natural stats of all Servines
	#region SpeciesServine
	public class SpeciesServine : PokemonSpecies
	{
#nullable enable
		private static SpeciesServine? _instance = null;
#nullable restore
        public static SpeciesServine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesServine();
                }
                return _instance;
            }
        }

		#region SpeciesServine Constructor
		public SpeciesServine() : base(
			496,
			"Servine",
			0.8,
			16.0,
			60, // HPs
			60, 75, // Attack & Defense
			60, 75, // Special Attack & Defense
			83		
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
				"Tackle",
				"Wrap",
				"Leer",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Aerial-Ace",
				"Calm-Mind",
				"Leaf-Blade",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Aqua-Tail",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Grass-Knot",
				"Coil",
				"Round",
				"Grass-Pledge",
				"Work-Up",
				"Leaf-Tornado",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Servine PokemonInstance Class
	#region Servine
	public class ServineInstance : PokemonInstance
	{
		#region Servine Constructors
		/// <summary>
		/// Servine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ServineInstance(string nickname, int level)
		: base(
				SpeciesServine.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Servine Builder only waiting for a Level
		/// </summary>
		public ServineInstance(int level)
		: base(
				SpeciesServine.Instance, // PokemonInstance Species
				"Servine", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Servine Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ServineInstance() : base(
			SpeciesServine.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}