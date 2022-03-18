using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Grotle Species to store common natural stats of all Grotles
	#region SpeciesGrotle
	public class SpeciesGrotle : PokemonSpecies
	{
#nullable enable
		private static SpeciesGrotle? _instance = null;
#nullable restore
        public static SpeciesGrotle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGrotle();
                }
                return _instance;
            }
        }

		#region SpeciesGrotle Constructor
		public SpeciesGrotle() : base(
			388,
			"Grotle",
			1.1,
			97.0,
			75, // HPs
			89, 85, // Attack & Defense
			55, 65, // Special Attack & Defense
			36		
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
				"Bite",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
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
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Superpower",
				"Secret-Power",
				"Bullet-Seed",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Rock-Climb",
				"Leaf-Storm",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Round",
				"Grass-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Grotle PokemonInstance Class
	#region Grotle
	public class GrotleInstance : PokemonInstance
	{
		#region Grotle Constructors
		/// <summary>
		/// Grotle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GrotleInstance(string nickname, int level)
		: base(
				SpeciesGrotle.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grotle Builder only waiting for a Level
		/// </summary>
		public GrotleInstance(int level)
		: base(
				SpeciesGrotle.Instance, // PokemonInstance Species
				"Grotle", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grotle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GrotleInstance() : base(
			SpeciesGrotle.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}