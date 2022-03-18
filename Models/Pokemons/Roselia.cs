using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Roselia Species to store common natural stats of all Roselias
	#region SpeciesRoselia
	public class SpeciesRoselia : PokemonSpecies
	{
#nullable enable
		private static SpeciesRoselia? _instance = null;
#nullable restore
        public static SpeciesRoselia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRoselia();
                }
                return _instance;
            }
        }

		#region SpeciesRoselia Constructor
		public SpeciesRoselia() : base(
			315,
			"Roselia",
			0.3,
			2.0,
			50, // HPs
			60, 45, // Attack & Defense
			100, 80, // Special Attack & Defense
			65		
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
				"Body-Slam",
				"Double-Edge",
				"Poison-Sting",
				"Pin-Missile",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Stun-Spore",
				"Sleep-Powder",
				"Petal-Dance",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Nightmare",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Spikes",
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
				"Ingrain",
				"Secret-Power",
				"Aromatherapy",
				"Grass-Whistle",
				"Bullet-Seed",
				"Covet",
				"Magical-Leaf",
				"Natural-Gift",
				"Worry-Seed",
				"Toxic-Spikes",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Petal-Blizzard",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Roselia PokemonInstance Class
	#region Roselia
	public class RoseliaInstance : PokemonInstance
	{
		#region Roselia Constructors
		/// <summary>
		/// Roselia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RoseliaInstance(string nickname, int level)
		: base(
				SpeciesRoselia.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roselia Builder only waiting for a Level
		/// </summary>
		public RoseliaInstance(int level)
		: base(
				SpeciesRoselia.Instance, // PokemonInstance Species
				"Roselia", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roselia Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RoseliaInstance() : base(
			SpeciesRoselia.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}