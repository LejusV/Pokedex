using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Carbink Species to store common natural stats of all Carbinks
	#region SpeciesCarbink
	public class SpeciesCarbink : PokemonSpecies
	{
#nullable enable
		private static SpeciesCarbink? _instance = null;
#nullable restore
        public static SpeciesCarbink Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCarbink();
                }
                return _instance;
            }
        }

		#region SpeciesCarbink Constructor
		public SpeciesCarbink() : base(
			"Carbink",
			0.3,
			5.7,
			50, // HPs
			50, 150, // Attack & Defense
			50, 150, // Special Attack & Defense
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
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Covet",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Magnet-Rise",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Trick-Room",
				"Stone-Edge",
				"Stealth-Rock",
				"Guard-Split",
				"Wonder-Room",
				"Smack-Down",
				"After-You",
				"Round",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Carbink PokemonInstance Class
	#region Carbink
	public class CarbinkInstance : PokemonInstance
	{
		#region Carbink Constructors
		/// <summary>
		/// Carbink Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CarbinkInstance(string nickname, int level)
		: base(
				703,
				SpeciesCarbink.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carbink Builder only waiting for a Level
		/// </summary>
		public CarbinkInstance(int level)
		: base(
				703,
				SpeciesCarbink.Instance, // PokemonInstance Species
				"Carbink", level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carbink Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Carbink() : base(
			703,
			SpeciesCarbink.Instance, // PokemonInstance Species
			Rock.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}