using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Diancie Species to store common natural stats of all Diancies
	#region SpeciesDiancie
	public class SpeciesDiancie : PokemonSpecies
	{
#nullable enable
		private static SpeciesDiancie? _instance = null;
#nullable restore
        public static SpeciesDiancie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDiancie();
                }
                return _instance;
            }
        }

		#region SpeciesDiancie Constructor
		public SpeciesDiancie() : base(
			719,
			"Diancie",
			0.7,
			8.8,
			50, // HPs
			100, 150, // Attack & Defense
			100, 150, // Special Attack & Defense
			50		
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
				"Hyper-Beam",
				"Rock-Throw",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Harden",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Sharpen",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Hail",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Endeavor",
				"Skill-Swap",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Covet",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Last-Resort",
				"Magnet-Rise",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Giga-Impact",
				"Trick-Room",
				"Stone-Edge",
				"Stealth-Rock",
				"Guard-Split",
				"Wonder-Room",
				"Psyshock",
				"Smack-Down",
				"After-You",
				"Round",
				"Moonblast",
				"Confide",
				"Diamond-Storm",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Diancie PokemonInstance Class
	#region Diancie
	public class DiancieInstance : PokemonInstance
	{
		#region Diancie Constructors
		/// <summary>
		/// Diancie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DiancieInstance(string nickname, int level)
		: base(
				SpeciesDiancie.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diancie Builder only waiting for a Level
		/// </summary>
		public DiancieInstance(int level)
		: base(
				SpeciesDiancie.Instance, // PokemonInstance Species
				"Diancie", level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diancie Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DiancieInstance() : base(
			SpeciesDiancie.Instance, // PokemonInstance Species
			Rock.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}