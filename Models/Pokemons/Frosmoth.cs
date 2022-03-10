using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Frosmoth Species to store common natural stats of all Frosmoths
	#region SpeciesFrosmoth
	public class SpeciesFrosmoth : PokemonSpecies
	{
#nullable enable
		private static SpeciesFrosmoth? _instance = null;
#nullable restore
        public static SpeciesFrosmoth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFrosmoth();
                }
                return _instance;
            }
        }

		#region SpeciesFrosmoth Constructor
		public SpeciesFrosmoth() : base(
			"Frosmoth",
			1.3,
			42.0,
			70, // HPs
			65, 60, // Attack & Defense
			125, 90, // Special Attack & Defense
			65		
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

	//Frosmoth PokemonInstance Class
	#region Frosmoth
	public class FrosmothInstance : PokemonInstance
	{
		#region Frosmoth Constructors
		/// <summary>
		/// Frosmoth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FrosmothInstance(string nickname, int level)
		: base(
				873,
				SpeciesFrosmoth.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frosmoth Builder only waiting for a Level
		/// </summary>
		public FrosmothInstance(int level)
		: base(
				873,
				SpeciesFrosmoth.Instance, // PokemonInstance Species
				"Frosmoth", level,
				Ice.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frosmoth Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Frosmoth() : base(
			873,
			SpeciesFrosmoth.Instance, // PokemonInstance Species
			Ice.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}