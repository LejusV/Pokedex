using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hatenna Species to store common natural stats of all Hatennas
	#region SpeciesHatenna
	public class SpeciesHatenna : PokemonSpecies
	{
#nullable enable
		private static SpeciesHatenna? _instance = null;
#nullable restore
        public static SpeciesHatenna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHatenna();
                }
                return _instance;
            }
        }

		#region SpeciesHatenna Constructor
		public SpeciesHatenna() : base(
			"Hatenna",
			0.4,
			3.4,
			42, // HPs
			30, 45, // Attack & Defense
			56, 53, // Special Attack & Defense
			39		
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
				
			};
		}
		#endregion
	}
	#endregion

	//Hatenna PokemonInstance Class
	#region Hatenna
	public class HatennaInstance : PokemonInstance
	{
		#region Hatenna Constructors
		/// <summary>
		/// Hatenna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HatennaInstance(string nickname, int level)
		: base(
				856,
				SpeciesHatenna.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatenna Builder only waiting for a Level
		/// </summary>
		public HatennaInstance(int level)
		: base(
				856,
				SpeciesHatenna.Instance, // PokemonInstance Species
				"Hatenna", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatenna Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Hatenna() : base(
			856,
			SpeciesHatenna.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}