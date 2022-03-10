using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Alcremie Species to store common natural stats of all Alcremies
	#region SpeciesAlcremie
	public class SpeciesAlcremie : PokemonSpecies
	{
#nullable enable
		private static SpeciesAlcremie? _instance = null;
#nullable restore
        public static SpeciesAlcremie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAlcremie();
                }
                return _instance;
            }
        }

		#region SpeciesAlcremie Constructor
		public SpeciesAlcremie() : base(
			"Alcremie",
			0.3,
			0.5,
			65, // HPs
			60, 75, // Attack & Defense
			110, 121, // Special Attack & Defense
			64		
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

	//Alcremie PokemonInstance Class
	#region Alcremie
	public class AlcremieInstance : PokemonInstance
	{
		#region Alcremie Constructors
		/// <summary>
		/// Alcremie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AlcremieInstance(string nickname, int level)
		: base(
				869,
				SpeciesAlcremie.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alcremie Builder only waiting for a Level
		/// </summary>
		public AlcremieInstance(int level)
		: base(
				869,
				SpeciesAlcremie.Instance, // PokemonInstance Species
				"Alcremie", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alcremie Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Alcremie() : base(
			869,
			SpeciesAlcremie.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}