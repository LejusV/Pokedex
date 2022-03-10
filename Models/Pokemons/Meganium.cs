using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Meganium Species to store common natural stats of all Meganiums
	#region SpeciesMeganium
	public class SpeciesMeganium : PokemonSpecies
	{
#nullable enable
		private static SpeciesMeganium? _instance = null;
#nullable restore
        public static SpeciesMeganium Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMeganium();
                }
                return _instance;
            }
        }

		#region SpeciesMeganium Constructor
		public SpeciesMeganium() : base(
			"Meganium",
			1.8,
			100.5,
			80, // HPs
			82, 100, // Attack & Defense
			83, 100, // Special Attack & Defense
			80		
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
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Petal-Dance",
				"Earthquake",
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
				"Outrage",
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
				"Frenzy-Plant",
				"Magical-Leaf",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Rock-Climb",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Petal-Blizzard",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Meganium PokemonInstance Class
	#region Meganium
	public class MeganiumInstance : PokemonInstance
	{
		#region Meganium Constructors
		/// <summary>
		/// Meganium Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MeganiumInstance(string nickname, int level)
		: base(
				154,
				SpeciesMeganium.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meganium Builder only waiting for a Level
		/// </summary>
		public MeganiumInstance(int level)
		: base(
				154,
				SpeciesMeganium.Instance, // PokemonInstance Species
				"Meganium", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meganium Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Meganium() : base(
			154,
			SpeciesMeganium.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}