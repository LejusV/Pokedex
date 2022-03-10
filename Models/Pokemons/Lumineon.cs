using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lumineon Species to store common natural stats of all Lumineons
	#region SpeciesLumineon
	public class SpeciesLumineon : PokemonSpecies
	{
#nullable enable
		private static SpeciesLumineon? _instance = null;
#nullable restore
        public static SpeciesLumineon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLumineon();
                }
                return _instance;
            }
        }

		#region SpeciesLumineon Constructor
		public SpeciesLumineon() : base(
			"Lumineon",
			1.2,
			24.0,
			69, // HPs
			69, 76, // Attack & Defense
			69, 86, // Special Attack & Defense
			91		
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
				"Pound",
				"Gust",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Psych-Up",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Aqua-Ring",
				"Aqua-Tail",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Soak",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Lumineon PokemonInstance Class
	#region Lumineon
	public class LumineonInstance : PokemonInstance
	{
		#region Lumineon Constructors
		/// <summary>
		/// Lumineon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LumineonInstance(string nickname, int level)
		: base(
				457,
				SpeciesLumineon.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lumineon Builder only waiting for a Level
		/// </summary>
		public LumineonInstance(int level)
		: base(
				457,
				SpeciesLumineon.Instance, // PokemonInstance Species
				"Lumineon", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lumineon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Lumineon() : base(
			457,
			SpeciesLumineon.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}