using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Glastrier Species to store common natural stats of all Glastriers
	#region SpeciesGlastrier
	public class SpeciesGlastrier : PokemonSpecies
	{
#nullable enable
		private static SpeciesGlastrier? _instance = null;
#nullable restore
        public static SpeciesGlastrier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGlastrier();
                }
                return _instance;
            }
        }

		#region SpeciesGlastrier Constructor
		public SpeciesGlastrier() : base(
			896,
			"Glastrier",
			2.2,
			800.0,
			100, // HPs
			145, 130, // Attack & Defense
			65, 110, // Special Attack & Defense
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
				
			};
		}
		#endregion
	}
	#endregion

	//Glastrier PokemonInstance Class
	#region Glastrier
	public class GlastrierInstance : PokemonInstance
	{
		#region Glastrier Constructors
		/// <summary>
		/// Glastrier Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GlastrierInstance(string nickname, int level)
		: base(
				SpeciesGlastrier.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glastrier Builder only waiting for a Level
		/// </summary>
		public GlastrierInstance(int level)
		: base(
				SpeciesGlastrier.Instance, // PokemonInstance Species
				"Glastrier", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glastrier Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GlastrierInstance() : base(
			SpeciesGlastrier.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}