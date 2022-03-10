using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chewtle Species to store common natural stats of all Chewtles
	#region SpeciesChewtle
	public class SpeciesChewtle : PokemonSpecies
	{
#nullable enable
		private static SpeciesChewtle? _instance = null;
#nullable restore
        public static SpeciesChewtle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChewtle();
                }
                return _instance;
            }
        }

		#region SpeciesChewtle Constructor
		public SpeciesChewtle() : base(
			"Chewtle",
			0.3,
			8.5,
			50, // HPs
			64, 50, // Attack & Defense
			38, 38, // Special Attack & Defense
			44		
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

	//Chewtle PokemonInstance Class
	#region Chewtle
	public class ChewtleInstance : PokemonInstance
	{
		#region Chewtle Constructors
		/// <summary>
		/// Chewtle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChewtleInstance(string nickname, int level)
		: base(
				833,
				SpeciesChewtle.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chewtle Builder only waiting for a Level
		/// </summary>
		public ChewtleInstance(int level)
		: base(
				833,
				SpeciesChewtle.Instance, // PokemonInstance Species
				"Chewtle", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chewtle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Chewtle() : base(
			833,
			SpeciesChewtle.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}