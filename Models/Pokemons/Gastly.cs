using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gastly Species to store common natural stats of all Gastlys
	#region SpeciesGastly
	public class SpeciesGastly : PokemonSpecies
	{
#nullable enable
		private static SpeciesGastly? _instance = null;
#nullable restore
        public static SpeciesGastly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGastly();
                }
                return _instance;
            }
        }

		#region SpeciesGastly Constructor
		public SpeciesGastly() : base(
			92,
			"Gastly",
			1.3,
			0.1,
			30, // HPs
			35, 30, // Attack & Defense
			100, 35, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Disable",
				"Mega-Drain",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Bide",
				"Self-Destruct",
				"Lick",
				"Smog",
				"Dream-Eater",
				"Psywave",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Zap-Cannon",
				"Destiny-Bond",
				"Perish-Song",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Knock-Off",
				"Skill-Swap",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Energy-Ball",
				"Trick-Room",
				"Captivate",
				"Ominous-Wind",
				"Wonder-Room",
				"Venoshock",
				"Telekinesis",
				"Foul-Play",
				"Round",
				"Clear-Smog",
				"Hex",
				"Reflect-Type",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Gastly PokemonInstance Class
	#region Gastly
	public class GastlyInstance : PokemonInstance
	{
		#region Gastly Constructors
		/// <summary>
		/// Gastly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GastlyInstance(string nickname, int level)
		: base(
				SpeciesGastly.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastly Builder only waiting for a Level
		/// </summary>
		public GastlyInstance(int level)
		: base(
				SpeciesGastly.Instance, // PokemonInstance Species
				"Gastly", level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastly Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GastlyInstance() : base(
			SpeciesGastly.Instance, // PokemonInstance Species
			Ghost.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}