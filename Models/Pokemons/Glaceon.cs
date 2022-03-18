using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Glaceon Species to store common natural stats of all Glaceons
	#region SpeciesGlaceon
	public class SpeciesGlaceon : PokemonSpecies
	{
#nullable enable
		private static SpeciesGlaceon? _instance = null;
#nullable restore
        public static SpeciesGlaceon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGlaceon();
                }
                return _instance;
            }
        }

		#region SpeciesGlaceon Constructor
		public SpeciesGlaceon() : base(
			471,
			"Glaceon",
			0.8,
			25.9,
			65, // HPs
			60, 110, // Attack & Defense
			130, 95, // Special Attack & Defense
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Tail-Whip",
				"Bite",
				"Roar",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Barrier",
				"Swift",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Shadow-Ball",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Covet",
				"Water-Pulse",
				"Natural-Gift",
				"Last-Resort",
				"Aqua-Tail",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Ice-Fang",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Frost-Breath",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion

	//Glaceon PokemonInstance Class
	#region Glaceon
	public class GlaceonInstance : PokemonInstance
	{
		#region Glaceon Constructors
		/// <summary>
		/// Glaceon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GlaceonInstance(string nickname, int level)
		: base(
				SpeciesGlaceon.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glaceon Builder only waiting for a Level
		/// </summary>
		public GlaceonInstance(int level)
		: base(
				SpeciesGlaceon.Instance, // PokemonInstance Species
				"Glaceon", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glaceon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GlaceonInstance() : base(
			SpeciesGlaceon.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}