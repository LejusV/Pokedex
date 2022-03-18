using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pincurchin Species to store common natural stats of all Pincurchins
	#region SpeciesPincurchin
	public class SpeciesPincurchin : PokemonSpecies
	{
#nullable enable
		private static SpeciesPincurchin? _instance = null;
#nullable restore
        public static SpeciesPincurchin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPincurchin();
                }
                return _instance;
            }
        }

		#region SpeciesPincurchin Constructor
		public SpeciesPincurchin() : base(
			871,
			"Pincurchin",
			0.3,
			1.0,
			48, // HPs
			101, 95, // Attack & Defense
			91, 85, // Special Attack & Defense
			15		
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

	//Pincurchin PokemonInstance Class
	#region Pincurchin
	public class PincurchinInstance : PokemonInstance
	{
		#region Pincurchin Constructors
		/// <summary>
		/// Pincurchin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PincurchinInstance(string nickname, int level)
		: base(
				SpeciesPincurchin.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pincurchin Builder only waiting for a Level
		/// </summary>
		public PincurchinInstance(int level)
		: base(
				SpeciesPincurchin.Instance, // PokemonInstance Species
				"Pincurchin", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pincurchin Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PincurchinInstance() : base(
			SpeciesPincurchin.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}