using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Koffing Species to store common natural stats of all Koffings
	#region SpeciesKoffing
	public class SpeciesKoffing : PokemonSpecies
	{
#nullable enable
		private static SpeciesKoffing? _instance = null;
#nullable restore
        public static SpeciesKoffing Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKoffing();
                }
                return _instance;
            }
        }

		#region SpeciesKoffing Constructor
		public SpeciesKoffing() : base(
			"Koffing",
			0.6,
			1.0,
			40, // HPs
			65, 95, // Attack & Defense
			60, 45, // Special Attack & Defense
			35		
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
				"Psybeam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
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
				"Psywave",
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
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Grudge",
				"Secret-Power",
				"Shock-Wave",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Toxic-Spikes",
				"Dark-Pulse",
				"Captivate",
				"Venoshock",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Belch",
				"Confide",
				"Venom-Drench",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Koffing PokemonInstance Class
	#region Koffing
	public class KoffingInstance : PokemonInstance
	{
		#region Koffing Constructors
		/// <summary>
		/// Koffing Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KoffingInstance(string nickname, int level)
		: base(
				109,
				SpeciesKoffing.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Koffing Builder only waiting for a Level
		/// </summary>
		public KoffingInstance(int level)
		: base(
				109,
				SpeciesKoffing.Instance, // PokemonInstance Species
				"Koffing", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Koffing Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Koffing() : base(
			109,
			SpeciesKoffing.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}