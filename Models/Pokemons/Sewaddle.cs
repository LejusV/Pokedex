using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sewaddle Species to store common natural stats of all Sewaddles
	#region SpeciesSewaddle
	public class SpeciesSewaddle : PokemonSpecies
	{
#nullable enable
		private static SpeciesSewaddle? _instance = null;
#nullable restore
        public static SpeciesSewaddle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSewaddle();
                }
                return _instance;
            }
        }

		#region SpeciesSewaddle Constructor
		public SpeciesSewaddle() : base(
			540,
			"Sewaddle",
			0.3,
			2.5,
			45, // HPs
			53, 70, // Attack & Defense
			40, 60, // Special Attack & Defense
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
				"Razor-Wind",
				"Cut",
				"Tackle",
				"Razor-Leaf",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Flail",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Magic-Coat",
				"Secret-Power",
				"Camouflage",
				"Silver-Wind",
				"Signal-Beam",
				"Iron-Defense",
				"Calm-Mind",
				"Payback",
				"Me-First",
				"Worry-Seed",
				"Seed-Bomb",
				"Air-Slash",
				"Bug-Buzz",
				"Energy-Ball",
				"Grass-Knot",
				"Bug-Bite",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Sticky-Web",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Sewaddle PokemonInstance Class
	#region Sewaddle
	public class SewaddleInstance : PokemonInstance
	{
		#region Sewaddle Constructors
		/// <summary>
		/// Sewaddle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SewaddleInstance(string nickname, int level)
		: base(
				SpeciesSewaddle.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sewaddle Builder only waiting for a Level
		/// </summary>
		public SewaddleInstance(int level)
		: base(
				SpeciesSewaddle.Instance, // PokemonInstance Species
				"Sewaddle", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sewaddle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SewaddleInstance() : base(
			SpeciesSewaddle.Instance, // PokemonInstance Species
			Bug.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}