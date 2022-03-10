using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Leafeon Species to store common natural stats of all Leafeons
	#region SpeciesLeafeon
	public class SpeciesLeafeon : PokemonSpecies
	{
#nullable enable
		private static SpeciesLeafeon? _instance = null;
#nullable restore
        public static SpeciesLeafeon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLeafeon();
                }
                return _instance;
            }
        }

		#region SpeciesLeafeon Constructor
		public SpeciesLeafeon() : base(
			"Leafeon",
			1.0,
			25.5,
			65, // HPs
			110, 130, // Attack & Defense
			60, 65, // Special Attack & Defense
			95		
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Tail-Whip",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Razor-Leaf",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Grass-Whistle",
				"Bullet-Seed",
				"Aerial-Ace",
				"Covet",
				"Magical-Leaf",
				"Leaf-Blade",
				"Natural-Gift",
				"Last-Resort",
				"Worry-Seed",
				"Seed-Bomb",
				"X-Scissor",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Leafeon PokemonInstance Class
	#region Leafeon
	public class LeafeonInstance : PokemonInstance
	{
		#region Leafeon Constructors
		/// <summary>
		/// Leafeon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LeafeonInstance(string nickname, int level)
		: base(
				470,
				SpeciesLeafeon.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leafeon Builder only waiting for a Level
		/// </summary>
		public LeafeonInstance(int level)
		: base(
				470,
				SpeciesLeafeon.Instance, // PokemonInstance Species
				"Leafeon", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leafeon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Leafeon() : base(
			470,
			SpeciesLeafeon.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}