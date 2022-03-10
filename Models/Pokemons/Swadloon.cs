using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Swadloon Species to store common natural stats of all Swadloons
	#region SpeciesSwadloon
	public class SpeciesSwadloon : PokemonSpecies
	{
#nullable enable
		private static SpeciesSwadloon? _instance = null;
#nullable restore
        public static SpeciesSwadloon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSwadloon();
                }
                return _instance;
            }
        }

		#region SpeciesSwadloon Constructor
		public SpeciesSwadloon() : base(
			"Swadloon",
			0.5,
			7.3,
			55, // HPs
			63, 90, // Attack & Defense
			50, 80, // Special Attack & Defense
			42		
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
				"Cut",
				"Tackle",
				"Razor-Leaf",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
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
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Magic-Coat",
				"Secret-Power",
				"Grass-Whistle",
				"Signal-Beam",
				"Iron-Defense",
				"Calm-Mind",
				"Payback",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Grass-Knot",
				"Bug-Bite",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Swadloon PokemonInstance Class
	#region Swadloon
	public class SwadloonInstance : PokemonInstance
	{
		#region Swadloon Constructors
		/// <summary>
		/// Swadloon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SwadloonInstance(string nickname, int level)
		: base(
				541,
				SpeciesSwadloon.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swadloon Builder only waiting for a Level
		/// </summary>
		public SwadloonInstance(int level)
		: base(
				541,
				SpeciesSwadloon.Instance, // PokemonInstance Species
				"Swadloon", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swadloon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Swadloon() : base(
			541,
			SpeciesSwadloon.Instance, // PokemonInstance Species
			Bug.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}