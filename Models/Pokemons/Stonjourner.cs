using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Stonjourner Species to store common natural stats of all Stonjourners
	#region SpeciesStonjourner
	public class SpeciesStonjourner : PokemonSpecies
	{
#nullable enable
		private static SpeciesStonjourner? _instance = null;
#nullable restore
        public static SpeciesStonjourner Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStonjourner();
                }
                return _instance;
            }
        }

		#region SpeciesStonjourner Constructor
		public SpeciesStonjourner() : base(
			874,
			"Stonjourner",
			2.5,
			520.0,
			100, // HPs
			125, 135, // Attack & Defense
			20, 20, // Special Attack & Defense
			70		
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

	//Stonjourner PokemonInstance Class
	#region Stonjourner
	public class StonjournerInstance : PokemonInstance
	{
		#region Stonjourner Constructors
		/// <summary>
		/// Stonjourner Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StonjournerInstance(string nickname, int level)
		: base(
				SpeciesStonjourner.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stonjourner Builder only waiting for a Level
		/// </summary>
		public StonjournerInstance(int level)
		: base(
				SpeciesStonjourner.Instance, // PokemonInstance Species
				"Stonjourner", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stonjourner Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public StonjournerInstance() : base(
			SpeciesStonjourner.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}