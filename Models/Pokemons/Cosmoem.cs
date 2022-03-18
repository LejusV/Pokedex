using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cosmoem Species to store common natural stats of all Cosmoems
	#region SpeciesCosmoem
	public class SpeciesCosmoem : PokemonSpecies
	{
#nullable enable
		private static SpeciesCosmoem? _instance = null;
#nullable restore
        public static SpeciesCosmoem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCosmoem();
                }
                return _instance;
            }
        }

		#region SpeciesCosmoem Constructor
		public SpeciesCosmoem() : base(
			790,
			"Cosmoem",
			0.1,
			999.9,
			43, // HPs
			29, 131, // Attack & Defense
			29, 131, // Special Attack & Defense
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
				"Cosmic-Power"
			};
		}
		#endregion
	}
	#endregion

	//Cosmoem PokemonInstance Class
	#region Cosmoem
	public class CosmoemInstance : PokemonInstance
	{
		#region Cosmoem Constructors
		/// <summary>
		/// Cosmoem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CosmoemInstance(string nickname, int level)
		: base(
				SpeciesCosmoem.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmoem Builder only waiting for a Level
		/// </summary>
		public CosmoemInstance(int level)
		: base(
				SpeciesCosmoem.Instance, // PokemonInstance Species
				"Cosmoem", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmoem Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CosmoemInstance() : base(
			SpeciesCosmoem.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}