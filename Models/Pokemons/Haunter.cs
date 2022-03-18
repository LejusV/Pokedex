using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Haunter Species to store common natural stats of all Haunters
	#region SpeciesHaunter
	public class SpeciesHaunter : PokemonSpecies
	{
#nullable enable
		private static SpeciesHaunter? _instance = null;
#nullable restore
        public static SpeciesHaunter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHaunter();
                }
                return _instance;
            }
        }

		#region SpeciesHaunter Constructor
		public SpeciesHaunter() : base(
			93,
			"Haunter",
			1.6,
			0.1,
			45, // HPs
			50, 45, // Attack & Defense
			115, 55, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
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
				"Bide",
				"Self-Destruct",
				"Lick",
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
				"Sludge-Bomb",
				"Zap-Cannon",
				"Destiny-Bond",
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
				"Snatch",
				"Secret-Power",
				"Shadow-Punch",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Energy-Ball",
				"Shadow-Claw",
				"Trick-Room",
				"Captivate",
				"Ominous-Wind",
				"Wonder-Room",
				"Venoshock",
				"Telekinesis",
				"Foul-Play",
				"Round",
				"Hex",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Haunter PokemonInstance Class
	#region Haunter
	public class HaunterInstance : PokemonInstance
	{
		#region Haunter Constructors
		/// <summary>
		/// Haunter Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HaunterInstance(string nickname, int level)
		: base(
				SpeciesHaunter.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haunter Builder only waiting for a Level
		/// </summary>
		public HaunterInstance(int level)
		: base(
				SpeciesHaunter.Instance, // PokemonInstance Species
				"Haunter", level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haunter Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HaunterInstance() : base(
			SpeciesHaunter.Instance, // PokemonInstance Species
			Ghost.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}