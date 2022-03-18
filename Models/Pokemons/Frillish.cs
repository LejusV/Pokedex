using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Frillish Species to store common natural stats of all Frillishs
	#region SpeciesFrillish
	public class SpeciesFrillish : PokemonSpecies
	{
#nullable enable
		private static SpeciesFrillish? _instance = null;
#nullable restore
        public static SpeciesFrillish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFrillish();
                }
                return _instance;
            }
        }

		#region SpeciesFrillish Constructor
		public SpeciesFrillish() : base(
			592,
			"Frillish",
			1.2,
			33.0,
			55, // HPs
			40, 50, // Attack & Defense
			65, 85, // Special Attack & Defense
			40		
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
				"Bind",
				"Mist",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Absorb",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Recover",
				"Confuse-Ray",
				"Waterfall",
				"Constrict",
				"Dream-Eater",
				"Bubble",
				"Flash",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Giga-Drain",
				"Swagger",
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
				"Hail",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Magic-Coat",
				"Secret-Power",
				"Dive",
				"Water-Spout",
				"Water-Sport",
				"Shock-Wave",
				"Water-Pulse",
				"Brine",
				"Wring-Out",
				"Dark-Pulse",
				"Energy-Ball",
				"Trick-Room",
				"Ominous-Wind",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Hex",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Frillish PokemonInstance Class
	#region Frillish
	public class FrillishInstance : PokemonInstance
	{
		#region Frillish Constructors
		/// <summary>
		/// Frillish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FrillishInstance(string nickname, int level)
		: base(
				SpeciesFrillish.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frillish Builder only waiting for a Level
		/// </summary>
		public FrillishInstance(int level)
		: base(
				SpeciesFrillish.Instance, // PokemonInstance Species
				"Frillish", level,
				Water.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frillish Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public FrillishInstance() : base(
			SpeciesFrillish.Instance, // PokemonInstance Species
			Water.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}