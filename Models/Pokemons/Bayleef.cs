using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bayleef Species to store common natural stats of all Bayleefs
	#region SpeciesBayleef
	public class SpeciesBayleef : PokemonSpecies
	{
#nullable enable
		private static SpeciesBayleef? _instance = null;
#nullable restore
        public static SpeciesBayleef Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBayleef();
                }
                return _instance;
            }
        }

		#region SpeciesBayleef Constructor
		public SpeciesBayleef() : base(
			153,
			"Bayleef",
			1.2,
			15.8,
			60, // HPs
			62, 80, // Attack & Defense
			63, 80, // Special Attack & Defense
			60		
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Counter",
				"Strength",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Magic-Coat",
				"Secret-Power",
				"Aromatherapy",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Bayleef PokemonInstance Class
	#region Bayleef
	public class BayleefInstance : PokemonInstance
	{
		#region Bayleef Constructors
		/// <summary>
		/// Bayleef Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BayleefInstance(string nickname, int level)
		: base(
				SpeciesBayleef.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bayleef Builder only waiting for a Level
		/// </summary>
		public BayleefInstance(int level)
		: base(
				SpeciesBayleef.Instance, // PokemonInstance Species
				"Bayleef", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bayleef Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BayleefInstance() : base(
			SpeciesBayleef.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}