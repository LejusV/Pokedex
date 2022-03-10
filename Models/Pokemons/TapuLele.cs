using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Lele Species to store common natural stats of all Tapu-Leles
	#region SpeciesTapu-Lele
	public class SpeciesTapuLele : PokemonSpecies
	{
#nullable enable
		private static SpeciesTapuLele? _instance = null;
#nullable restore
        public static SpeciesTapuLele Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTapuLele();
                }
                return _instance;
            }
        }

		#region SpeciesTapu-Lele Constructor
		public SpeciesTapuLele() : base(
			"Tapu-Lele",
			1.2,
			18.6,
			70, // HPs
			85, 75, // Attack & Defense
			130, 115, // Special Attack & Defense
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
				"Psybeam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Psywave",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Mean-Look",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Torment",
				"Flatter",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Skill-Swap",
				"Astonish",
				"Aromatherapy",
				"Tickle",
				"Extrasensory",
				"Calm-Mind",
				"Fling",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Round",
				"Echoed-Voice",
				"Draining-Kiss",
				"Moonblast",
				"Confide",
				"Aromatic-Mist",
				"Dazzling-Gleam",
				"Psychic-Terrain",
				"Natures-Madness"
			};
		}
		#endregion
	}
	#endregion

	//Tapu-Lele PokemonInstance Class
	#region Tapu-Lele
	public class TapuLeleInstance : PokemonInstance
	{
		#region Tapu-Lele Constructors
		/// <summary>
		/// Tapu-Lele Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TapuLeleInstance(string nickname, int level)
		: base(
				786,
				SpeciesTapuLele.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Lele Builder only waiting for a Level
		/// </summary>
		public TapuLeleInstance(int level)
		: base(
				786,
				SpeciesTapuLele.Instance, // PokemonInstance Species
				"Tapu-Lele", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Lele Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TapuLele() : base(
			786,
			SpeciesTapuLele.Instance, // PokemonInstance Species
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}