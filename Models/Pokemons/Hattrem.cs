using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hattrem Species to store common natural stats of all Hattrems
	#region SpeciesHattrem
	public class SpeciesHattrem : PokemonSpecies
	{
#nullable enable
		private static SpeciesHattrem? _instance = null;
#nullable restore
        public static SpeciesHattrem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHattrem();
                }
                return _instance;
            }
        }

		#region SpeciesHattrem Constructor
		public SpeciesHattrem() : base(
			"Hattrem",
			0.6,
			4.8,
			57, // HPs
			40, 65, // Attack & Defense
			86, 73, // Special Attack & Defense
			49		
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

	//Hattrem PokemonInstance Class
	#region Hattrem
	public class HattremInstance : PokemonInstance
	{
		#region Hattrem Constructors
		/// <summary>
		/// Hattrem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HattremInstance(string nickname, int level)
		: base(
				857,
				SpeciesHattrem.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hattrem Builder only waiting for a Level
		/// </summary>
		public HattremInstance(int level)
		: base(
				857,
				SpeciesHattrem.Instance, // PokemonInstance Species
				"Hattrem", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hattrem Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Hattrem() : base(
			857,
			SpeciesHattrem.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}