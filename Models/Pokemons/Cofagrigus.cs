using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cofagrigus Species to store common natural stats of all Cofagriguss
	#region SpeciesCofagrigus
	public class SpeciesCofagrigus : PokemonSpecies
	{
#nullable enable
		private static SpeciesCofagrigus? _instance = null;
#nullable restore
        public static SpeciesCofagrigus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCofagrigus();
                }
                return _instance;
            }
        }

		#region SpeciesCofagrigus Constructor
		public SpeciesCofagrigus() : base(
			563,
			"Cofagrigus",
			1.7,
			76.5,
			58, // HPs
			50, 145, // Attack & Defense
			95, 105, // Special Attack & Defense
			30		
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
				"Disable",
				"Hyper-Beam",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Haze",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Destiny-Bond",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Facade",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Knock-Off",
				"Skill-Swap",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Iron-Defense",
				"Block",
				"Calm-Mind",
				"Shock-Wave",
				"Payback",
				"Embargo",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Ominous-Wind",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Telekinesis",
				"After-You",
				"Round",
				"Hex",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Cofagrigus PokemonInstance Class
	#region Cofagrigus
	public class CofagrigusInstance : PokemonInstance
	{
		#region Cofagrigus Constructors
		/// <summary>
		/// Cofagrigus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CofagrigusInstance(string nickname, int level)
		: base(
				SpeciesCofagrigus.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cofagrigus Builder only waiting for a Level
		/// </summary>
		public CofagrigusInstance(int level)
		: base(
				SpeciesCofagrigus.Instance, // PokemonInstance Species
				"Cofagrigus", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cofagrigus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CofagrigusInstance() : base(
			SpeciesCofagrigus.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}