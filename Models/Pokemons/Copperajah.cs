using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Copperajah Species to store common natural stats of all Copperajahs
	#region SpeciesCopperajah
	public class SpeciesCopperajah : PokemonSpecies
	{
#nullable enable
		private static SpeciesCopperajah? _instance = null;
#nullable restore
        public static SpeciesCopperajah Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCopperajah();
                }
                return _instance;
            }
        }

		#region SpeciesCopperajah Constructor
		public SpeciesCopperajah() : base(
			"Copperajah",
			3.0,
			650.0,
			122, // HPs
			130, 69, // Attack & Defense
			80, 69, // Special Attack & Defense
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

	//Copperajah PokemonInstance Class
	#region Copperajah
	public class CopperajahInstance : PokemonInstance
	{
		#region Copperajah Constructors
		/// <summary>
		/// Copperajah Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CopperajahInstance(string nickname, int level)
		: base(
				879,
				SpeciesCopperajah.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Copperajah Builder only waiting for a Level
		/// </summary>
		public CopperajahInstance(int level)
		: base(
				879,
				SpeciesCopperajah.Instance, // PokemonInstance Species
				"Copperajah", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Copperajah Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Copperajah() : base(
			879,
			SpeciesCopperajah.Instance, // PokemonInstance Species
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}