using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Weezing Species to store common natural stats of all Weezings
	#region SpeciesWeezing
	public class SpeciesWeezing : PokemonSpecies
	{
#nullable enable
		private static SpeciesWeezing? _instance = null;
#nullable restore
        public static SpeciesWeezing Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWeezing();
                }
                return _instance;
            }
        }

		#region SpeciesWeezing Constructor
		public SpeciesWeezing() : base(
			"Weezing",
			1.2,
			9.5,
			65, // HPs
			90, 120, // Attack & Defense
			85, 70, // Special Attack & Defense
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
				"Tackle",
				"Flamethrower",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Haze",
				"Bide",
				"Self-Destruct",
				"Smog",
				"Sludge",
				"Fire-Blast",
				"Poison-Gas",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Zap-Cannon",
				"Destiny-Bond",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Shock-Wave",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Dark-Pulse",
				"Giga-Impact",
				"Captivate",
				"Double-Hit",
				"Venoshock",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Belch",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Weezing PokemonInstance Class
	#region Weezing
	public class WeezingInstance : PokemonInstance
	{
		#region Weezing Constructors
		/// <summary>
		/// Weezing Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WeezingInstance(string nickname, int level)
		: base(
				110,
				SpeciesWeezing.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weezing Builder only waiting for a Level
		/// </summary>
		public WeezingInstance(int level)
		: base(
				110,
				SpeciesWeezing.Instance, // PokemonInstance Species
				"Weezing", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weezing Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Weezing() : base(
			110,
			SpeciesWeezing.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}