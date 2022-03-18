using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Finneon Species to store common natural stats of all Finneons
	#region SpeciesFinneon
	public class SpeciesFinneon : PokemonSpecies
	{
#nullable enable
		private static SpeciesFinneon? _instance = null;
#nullable restore
        public static SpeciesFinneon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFinneon();
                }
                return _instance;
            }
        }

		#region SpeciesFinneon Constructor
		public SpeciesFinneon() : base(
			456,
			"Finneon",
			0.4,
			7.0,
			49, // HPs
			49, 56, // Attack & Defense
			49, 61, // Special Attack & Defense
			66		
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
				"Psybeam",
				"Aurora-Beam",
				"Toxic",
				"Agility",
				"Double-Team",
				"Confuse-Ray",
				"Waterfall",
				"Swift",
				"Flash",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Icy-Wind",
				"Endure",
				"Charm",
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
				"Nature-Power",
				"Secret-Power",
				"Dive",
				"Air-Cutter",
				"Silver-Wind",
				"Tickle",
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

	//Finneon PokemonInstance Class
	#region Finneon
	public class FinneonInstance : PokemonInstance
	{
		#region Finneon Constructors
		/// <summary>
		/// Finneon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FinneonInstance(string nickname, int level)
		: base(
				SpeciesFinneon.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Finneon Builder only waiting for a Level
		/// </summary>
		public FinneonInstance(int level)
		: base(
				SpeciesFinneon.Instance, // PokemonInstance Species
				"Finneon", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Finneon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public FinneonInstance() : base(
			SpeciesFinneon.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}