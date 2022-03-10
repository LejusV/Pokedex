using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Eiscue-Ice Species to store common natural stats of all Eiscue-Ices
	#region SpeciesEiscue-Ice
	public class SpeciesEiscueIce : PokemonSpecies
	{
#nullable enable
		private static SpeciesEiscueIce? _instance = null;
#nullable restore
        public static SpeciesEiscueIce Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEiscueIce();
                }
                return _instance;
            }
        }

		#region SpeciesEiscue-Ice Constructor
		public SpeciesEiscueIce() : base(
			"Eiscue-Ice",
			1.4,
			89.0,
			75, // HPs
			80, 110, // Attack & Defense
			65, 90, // Special Attack & Defense
			50		
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

	//Eiscue-Ice PokemonInstance Class
	#region Eiscue-Ice
	public class EiscueIceInstance : PokemonInstance
	{
		#region Eiscue-Ice Constructors
		/// <summary>
		/// Eiscue-Ice Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EiscueIceInstance(string nickname, int level)
		: base(
				875,
				SpeciesEiscueIce.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eiscue-Ice Builder only waiting for a Level
		/// </summary>
		public EiscueIceInstance(int level)
		: base(
				875,
				SpeciesEiscueIce.Instance, // PokemonInstance Species
				"Eiscue-Ice", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eiscue-Ice Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public EiscueIce() : base(
			875,
			SpeciesEiscueIce.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}