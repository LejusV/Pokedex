using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Budew Species to store common natural stats of all Budews
	#region SpeciesBudew
	public class SpeciesBudew : PokemonSpecies
	{
#nullable enable
		private static SpeciesBudew? _instance = null;
#nullable restore
        public static SpeciesBudew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBudew();
                }
                return _instance;
            }
        }

		#region SpeciesBudew Constructor
		public SpeciesBudew() : base(
			"Budew",
			0.2,
			1.2,
			40, // HPs
			30, 35, // Attack & Defense
			50, 70, // Special Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Pin-Missile",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Spikes",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Grass-Whistle",
				"Extrasensory",
				"Bullet-Seed",
				"Covet",
				"Water-Sport",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Budew PokemonInstance Class
	#region Budew
	public class BudewInstance : PokemonInstance
	{
		#region Budew Constructors
		/// <summary>
		/// Budew Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BudewInstance(string nickname, int level)
		: base(
				406,
				SpeciesBudew.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Budew Builder only waiting for a Level
		/// </summary>
		public BudewInstance(int level)
		: base(
				406,
				SpeciesBudew.Instance, // PokemonInstance Species
				"Budew", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Budew Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Budew() : base(
			406,
			SpeciesBudew.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}