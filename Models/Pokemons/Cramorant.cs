using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cramorant Species to store common natural stats of all Cramorants
	#region SpeciesCramorant
	public class SpeciesCramorant : PokemonSpecies
	{
#nullable enable
		private static SpeciesCramorant? _instance = null;
#nullable restore
        public static SpeciesCramorant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCramorant();
                }
                return _instance;
            }
        }

		#region SpeciesCramorant Constructor
		public SpeciesCramorant() : base(
			845,
			"Cramorant",
			0.8,
			18.0,
			70, // HPs
			85, 55, // Attack & Defense
			85, 95, // Special Attack & Defense
			85		
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

	//Cramorant PokemonInstance Class
	#region Cramorant
	public class CramorantInstance : PokemonInstance
	{
		#region Cramorant Constructors
		/// <summary>
		/// Cramorant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CramorantInstance(string nickname, int level)
		: base(
				SpeciesCramorant.Instance, // Pokemon Species
				nickname, level,
				Flying.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cramorant Builder only waiting for a Level
		/// </summary>
		public CramorantInstance(int level)
		: base(
				SpeciesCramorant.Instance, // PokemonInstance Species
				"Cramorant", level,
				Flying.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cramorant Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CramorantInstance() : base(
			SpeciesCramorant.Instance, // PokemonInstance Species
			Flying.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}