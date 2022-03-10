using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Glalie Species to store common natural stats of all Glalies
	#region SpeciesGlalie
	public class SpeciesGlalie : PokemonSpecies
	{
#nullable enable
		private static SpeciesGlalie? _instance = null;
#nullable restore
        public static SpeciesGlalie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGlalie();
                }
                return _instance;
            }
        }

		#region SpeciesGlalie Constructor
		public SpeciesGlalie() : base(
			"Glalie",
			1.5,
			256.5,
			80, // HPs
			80, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Self-Destruct",
				"Flash",
				"Explosion",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Spite",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Shadow-Ball",
				"Hail",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Signal-Beam",
				"Sheer-Cold",
				"Block",
				"Water-Pulse",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Dark-Pulse",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Ice-Fang",
				"Iron-Head",
				"Captivate",
				"Round",
				"Bulldoze",
				"Frost-Breath",
				"Freeze-Dry",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Glalie PokemonInstance Class
	#region Glalie
	public class GlalieInstance : PokemonInstance
	{
		#region Glalie Constructors
		/// <summary>
		/// Glalie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GlalieInstance(string nickname, int level)
		: base(
				362,
				SpeciesGlalie.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glalie Builder only waiting for a Level
		/// </summary>
		public GlalieInstance(int level)
		: base(
				362,
				SpeciesGlalie.Instance, // PokemonInstance Species
				"Glalie", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glalie Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Glalie() : base(
			362,
			SpeciesGlalie.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}