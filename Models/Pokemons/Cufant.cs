using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cufant Species to store common natural stats of all Cufants
	#region SpeciesCufant
	public class SpeciesCufant : PokemonSpecies
	{
#nullable enable
		private static SpeciesCufant? _instance = null;
#nullable restore
        public static SpeciesCufant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCufant();
                }
                return _instance;
            }
        }

		#region SpeciesCufant Constructor
		public SpeciesCufant() : base(
			"Cufant",
			1.2,
			100.0,
			72, // HPs
			80, 49, // Attack & Defense
			40, 49, // Special Attack & Defense
			40		
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

	//Cufant PokemonInstance Class
	#region Cufant
	public class CufantInstance : PokemonInstance
	{
		#region Cufant Constructors
		/// <summary>
		/// Cufant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CufantInstance(string nickname, int level)
		: base(
				878,
				SpeciesCufant.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cufant Builder only waiting for a Level
		/// </summary>
		public CufantInstance(int level)
		: base(
				878,
				SpeciesCufant.Instance, // PokemonInstance Species
				"Cufant", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cufant Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cufant() : base(
			878,
			SpeciesCufant.Instance, // PokemonInstance Species
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}