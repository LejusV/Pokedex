using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Regieleki Species to store common natural stats of all Regielekis
	#region SpeciesRegieleki
	public class SpeciesRegieleki : PokemonSpecies
	{
#nullable enable
		private static SpeciesRegieleki? _instance = null;
#nullable restore
        public static SpeciesRegieleki Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRegieleki();
                }
                return _instance;
            }
        }

		#region SpeciesRegieleki Constructor
		public SpeciesRegieleki() : base(
			894,
			"Regieleki",
			1.2,
			145.0,
			80, // HPs
			100, 50, // Attack & Defense
			100, 50, // Special Attack & Defense
			200		
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

	//Regieleki PokemonInstance Class
	#region Regieleki
	public class RegielekiInstance : PokemonInstance
	{
		#region Regieleki Constructors
		/// <summary>
		/// Regieleki Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RegielekiInstance(string nickname, int level)
		: base(
				SpeciesRegieleki.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regieleki Builder only waiting for a Level
		/// </summary>
		public RegielekiInstance(int level)
		: base(
				SpeciesRegieleki.Instance, // PokemonInstance Species
				"Regieleki", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regieleki Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RegielekiInstance() : base(
			SpeciesRegieleki.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}