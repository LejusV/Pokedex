using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Carnivine Species to store common natural stats of all Carnivines
	#region SpeciesCarnivine
	public class SpeciesCarnivine : PokemonSpecies
	{
#nullable enable
		private static SpeciesCarnivine? _instance = null;
#nullable restore
        public static SpeciesCarnivine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCarnivine();
                }
                return _instance;
            }
        }

		#region SpeciesCarnivine Constructor
		public SpeciesCarnivine() : base(
			"Carnivine",
			1.4,
			27.0,
			74, // HPs
			100, 72, // Attack & Defense
			90, 72, // Special Attack & Defense
			46		
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
				"Bite",
				"Hyper-Beam",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Knock-Off",
				"Secret-Power",
				"Grass-Whistle",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Rage-Powder",
				"Acid-Spray",
				"Round",
				"Leaf-Tornado",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Carnivine PokemonInstance Class
	#region Carnivine
	public class CarnivineInstance : PokemonInstance
	{
		#region Carnivine Constructors
		/// <summary>
		/// Carnivine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CarnivineInstance(string nickname, int level)
		: base(
				455,
				SpeciesCarnivine.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carnivine Builder only waiting for a Level
		/// </summary>
		public CarnivineInstance(int level)
		: base(
				455,
				SpeciesCarnivine.Instance, // PokemonInstance Species
				"Carnivine", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carnivine Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Carnivine() : base(
			455,
			SpeciesCarnivine.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}