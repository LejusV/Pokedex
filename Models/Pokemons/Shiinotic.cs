using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shiinotic Species to store common natural stats of all Shiinotics
	#region SpeciesShiinotic
	public class SpeciesShiinotic : PokemonSpecies
	{
#nullable enable
		private static SpeciesShiinotic? _instance = null;
#nullable restore
        public static SpeciesShiinotic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShiinotic();
                }
                return _instance;
            }
        }

		#region SpeciesShiinotic Constructor
		public SpeciesShiinotic() : base(
			"Shiinotic",
			1.0,
			11.5,
			60, // HPs
			45, 80, // Attack & Defense
			90, 100, // Special Attack & Defense
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
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Sleep-Powder",
				"Thunder-Wave",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Dream-Eater",
				"Spore",
				"Flash",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Nature-Power",
				"Ingrain",
				"Astonish",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Strength-Sap",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion

	//Shiinotic PokemonInstance Class
	#region Shiinotic
	public class ShiinoticInstance : PokemonInstance
	{
		#region Shiinotic Constructors
		/// <summary>
		/// Shiinotic Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShiinoticInstance(string nickname, int level)
		: base(
				756,
				SpeciesShiinotic.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiinotic Builder only waiting for a Level
		/// </summary>
		public ShiinoticInstance(int level)
		: base(
				756,
				SpeciesShiinotic.Instance, // PokemonInstance Species
				"Shiinotic", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiinotic Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Shiinotic() : base(
			756,
			SpeciesShiinotic.Instance, // PokemonInstance Species
			Grass.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}