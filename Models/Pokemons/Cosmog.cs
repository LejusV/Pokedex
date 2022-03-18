using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cosmog Species to store common natural stats of all Cosmogs
	#region SpeciesCosmog
	public class SpeciesCosmog : PokemonSpecies
	{
#nullable enable
		private static SpeciesCosmog? _instance = null;
#nullable restore
        public static SpeciesCosmog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCosmog();
                }
                return _instance;
            }
        }

		#region SpeciesCosmog Constructor
		public SpeciesCosmog() : base(
			789,
			"Cosmog",
			0.2,
			0.1,
			43, // HPs
			29, 31, // Attack & Defense
			29, 31, // Special Attack & Defense
			37		
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
				"Teleport",
				"Splash"
			};
		}
		#endregion
	}
	#endregion

	//Cosmog PokemonInstance Class
	#region Cosmog
	public class CosmogInstance : PokemonInstance
	{
		#region Cosmog Constructors
		/// <summary>
		/// Cosmog Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CosmogInstance(string nickname, int level)
		: base(
				SpeciesCosmog.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmog Builder only waiting for a Level
		/// </summary>
		public CosmogInstance(int level)
		: base(
				SpeciesCosmog.Instance, // PokemonInstance Species
				"Cosmog", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmog Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CosmogInstance() : base(
			SpeciesCosmog.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}