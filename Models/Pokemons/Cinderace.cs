using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cinderace Species to store common natural stats of all Cinderaces
	#region SpeciesCinderace
	public class SpeciesCinderace : PokemonSpecies
	{
#nullable enable
		private static SpeciesCinderace? _instance = null;
#nullable restore
        public static SpeciesCinderace Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCinderace();
                }
                return _instance;
            }
        }

		#region SpeciesCinderace Constructor
		public SpeciesCinderace() : base(
			815,
			"Cinderace",
			1.4,
			33.0,
			80, // HPs
			116, 75, // Attack & Defense
			65, 75, // Special Attack & Defense
			119		
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

	//Cinderace PokemonInstance Class
	#region Cinderace
	public class CinderaceInstance : PokemonInstance
	{
		#region Cinderace Constructors
		/// <summary>
		/// Cinderace Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CinderaceInstance(string nickname, int level)
		: base(
				SpeciesCinderace.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinderace Builder only waiting for a Level
		/// </summary>
		public CinderaceInstance(int level)
		: base(
				SpeciesCinderace.Instance, // PokemonInstance Species
				"Cinderace", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinderace Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CinderaceInstance() : base(
			SpeciesCinderace.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}