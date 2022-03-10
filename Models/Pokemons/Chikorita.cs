using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chikorita Species to store common natural stats of all Chikoritas
	#region SpeciesChikorita
	public class SpeciesChikorita : PokemonSpecies
	{
#nullable enable
		private static SpeciesChikorita? _instance = null;
#nullable restore
        public static SpeciesChikorita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChikorita();
                }
                return _instance;
            }
        }

		#region SpeciesChikorita Constructor
		public SpeciesChikorita() : base(
			"Chikorita",
			0.9,
			6.4,
			45, // HPs
			49, 65, // Attack & Defense
			49, 65, // Special Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Vine-Whip",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Counter",
				"Leech-Seed",
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
				"Flail",
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
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Magic-Coat",
				"Refresh",
				"Secret-Power",
				"Aromatherapy",
				"Grass-Whistle",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Wring-Out",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Grass-Pledge",
				"Work-Up",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Chikorita PokemonInstance Class
	#region Chikorita
	public class ChikoritaInstance : PokemonInstance
	{
		#region Chikorita Constructors
		/// <summary>
		/// Chikorita Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChikoritaInstance(string nickname, int level)
		: base(
				152,
				SpeciesChikorita.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chikorita Builder only waiting for a Level
		/// </summary>
		public ChikoritaInstance(int level)
		: base(
				152,
				SpeciesChikorita.Instance, // PokemonInstance Species
				"Chikorita", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chikorita Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Chikorita() : base(
			152,
			SpeciesChikorita.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}