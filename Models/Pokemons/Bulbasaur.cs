using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bulbasaur Species to store common natural stats of all Bulbasaurs
	#region SpeciesBulbasaur
	public class SpeciesBulbasaur : PokemonSpecies
	{
#nullable enable
		private static SpeciesBulbasaur? _instance = null;
#nullable restore
        public static SpeciesBulbasaur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBulbasaur();
                }
                return _instance;
            }
        }

		#region SpeciesBulbasaur Constructor
		public SpeciesBulbasaur() : base(
			"Bulbasaur",
			0.7,
			6.9,
			45, // HPs
			49, 49, // Attack & Defense
			65, 65, // Special Attack & Defense
			45		
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
				"Swords-Dance",
				"Cut",
				"Bind",
				"Vine-Whip",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Strength",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Sleep-Powder",
				"Petal-Dance",
				"String-Shot",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Sludge",
				"Skull-Bash",
				"Amnesia",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Charm",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Knock-Off",
				"Secret-Power",
				"Grass-Whistle",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Work-Up",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Bulbasaur PokemonInstance Class
	#region Bulbasaur
	public class BulbasaurInstance : PokemonInstance
	{
		#region Bulbasaur Constructors
		/// <summary>
		/// Bulbasaur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BulbasaurInstance(string nickname, int level)
		: base(
				1,
				SpeciesBulbasaur.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bulbasaur Builder only waiting for a Level
		/// </summary>
		public BulbasaurInstance(int level)
		: base(
				1,
				SpeciesBulbasaur.Instance, // PokemonInstance Species
				"Bulbasaur", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bulbasaur Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Bulbasaur() : base(
			1,
			SpeciesBulbasaur.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}