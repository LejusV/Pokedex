using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Alomomola Species to store common natural stats of all Alomomolas
	#region SpeciesAlomomola
	public class SpeciesAlomomola : PokemonSpecies
	{
#nullable enable
		private static SpeciesAlomomola? _instance = null;
#nullable restore
        public static SpeciesAlomomola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAlomomola();
                }
                return _instance;
            }
        }

		#region SpeciesAlomomola Constructor
		public SpeciesAlomomola() : base(
			"Alomomola",
			1.2,
			31.6,
			165, // HPs
			75, 80, // Attack & Defense
			40, 45, // Special Attack & Defense
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
				"Pound",
				"Double-Slap",
				"Mist",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Waterfall",
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
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Psych-Up",
				"Shadow-Ball",
				"Whirlpool",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Wish",
				"Magic-Coat",
				"Knock-Off",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Tickle",
				"Bounce",
				"Water-Sport",
				"Calm-Mind",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Healing-Wish",
				"Brine",
				"Aqua-Ring",
				"Aqua-Jet",
				"Wide-Guard",
				"Soak",
				"Round",
				"Scald",
				"Heal-Pulse",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Alomomola PokemonInstance Class
	#region Alomomola
	public class AlomomolaInstance : PokemonInstance
	{
		#region Alomomola Constructors
		/// <summary>
		/// Alomomola Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AlomomolaInstance(string nickname, int level)
		: base(
				594,
				SpeciesAlomomola.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alomomola Builder only waiting for a Level
		/// </summary>
		public AlomomolaInstance(int level)
		: base(
				594,
				SpeciesAlomomola.Instance, // PokemonInstance Species
				"Alomomola", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alomomola Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Alomomola() : base(
			594,
			SpeciesAlomomola.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}