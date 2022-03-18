using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rookidee Species to store common natural stats of all Rookidees
	#region SpeciesRookidee
	public class SpeciesRookidee : PokemonSpecies
	{
#nullable enable
		private static SpeciesRookidee? _instance = null;
#nullable restore
        public static SpeciesRookidee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRookidee();
                }
                return _instance;
            }
        }

		#region SpeciesRookidee Constructor
		public SpeciesRookidee() : base(
			821,
			"Rookidee",
			0.2,
			1.8,
			38, // HPs
			47, 35, // Attack & Defense
			33, 35, // Special Attack & Defense
			57		
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

	//Rookidee PokemonInstance Class
	#region Rookidee
	public class RookideeInstance : PokemonInstance
	{
		#region Rookidee Constructors
		/// <summary>
		/// Rookidee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RookideeInstance(string nickname, int level)
		: base(
				SpeciesRookidee.Instance, // Pokemon Species
				nickname, level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rookidee Builder only waiting for a Level
		/// </summary>
		public RookideeInstance(int level)
		: base(
				SpeciesRookidee.Instance, // PokemonInstance Species
				"Rookidee", level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rookidee Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RookideeInstance() : base(
			SpeciesRookidee.Instance, // PokemonInstance Species
			Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}