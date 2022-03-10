using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Roserade Species to store common natural stats of all Roserades
	#region SpeciesRoserade
	public class SpeciesRoserade : PokemonSpecies
	{
#nullable enable
		private static SpeciesRoserade? _instance = null;
#nullable restore
        public static SpeciesRoserade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRoserade();
                }
                return _instance;
            }
        }

		#region SpeciesRoserade Constructor
		public SpeciesRoserade() : base(
			"Roserade",
			0.9,
			14.5,
			60, // HPs
			70, 65, // Attack & Defense
			125, 105, // Special Attack & Defense
			90		
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
				"Poison-Sting",
				"Hyper-Beam",
				"Mega-Drain",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
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
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Weather-Ball",
				"Bullet-Seed",
				"Covet",
				"Magical-Leaf",
				"Natural-Gift",
				"Worry-Seed",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Grassy-Terrain",
				"Confide",
				"Venom-Drench",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Roserade PokemonInstance Class
	#region Roserade
	public class RoseradeInstance : PokemonInstance
	{
		#region Roserade Constructors
		/// <summary>
		/// Roserade Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RoseradeInstance(string nickname, int level)
		: base(
				407,
				SpeciesRoserade.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roserade Builder only waiting for a Level
		/// </summary>
		public RoseradeInstance(int level)
		: base(
				407,
				SpeciesRoserade.Instance, // PokemonInstance Species
				"Roserade", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roserade Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Roserade() : base(
			407,
			SpeciesRoserade.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}