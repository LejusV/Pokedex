using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Corviknight Species to store common natural stats of all Corviknights
	#region SpeciesCorviknight
	public class SpeciesCorviknight : PokemonSpecies
	{
#nullable enable
		private static SpeciesCorviknight? _instance = null;
#nullable restore
        public static SpeciesCorviknight Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCorviknight();
                }
                return _instance;
            }
        }

		#region SpeciesCorviknight Constructor
		public SpeciesCorviknight() : base(
			823,
			"Corviknight",
			2.2,
			75.0,
			98, // HPs
			87, 105, // Attack & Defense
			53, 85, // Special Attack & Defense
			67		
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

	//Corviknight PokemonInstance Class
	#region Corviknight
	public class CorviknightInstance : PokemonInstance
	{
		#region Corviknight Constructors
		/// <summary>
		/// Corviknight Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CorviknightInstance(string nickname, int level)
		: base(
				SpeciesCorviknight.Instance, // Pokemon Species
				nickname, level,
				Flying.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corviknight Builder only waiting for a Level
		/// </summary>
		public CorviknightInstance(int level)
		: base(
				SpeciesCorviknight.Instance, // PokemonInstance Species
				"Corviknight", level,
				Flying.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corviknight Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CorviknightInstance() : base(
			SpeciesCorviknight.Instance, // PokemonInstance Species
			Flying.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}