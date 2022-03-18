using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Impidimp Species to store common natural stats of all Impidimps
	#region SpeciesImpidimp
	public class SpeciesImpidimp : PokemonSpecies
	{
#nullable enable
		private static SpeciesImpidimp? _instance = null;
#nullable restore
        public static SpeciesImpidimp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesImpidimp();
                }
                return _instance;
            }
        }

		#region SpeciesImpidimp Constructor
		public SpeciesImpidimp() : base(
			859,
			"Impidimp",
			0.4,
			5.5,
			45, // HPs
			45, 30, // Attack & Defense
			55, 40, // Special Attack & Defense
			50		
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

	//Impidimp PokemonInstance Class
	#region Impidimp
	public class ImpidimpInstance : PokemonInstance
	{
		#region Impidimp Constructors
		/// <summary>
		/// Impidimp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ImpidimpInstance(string nickname, int level)
		: base(
				SpeciesImpidimp.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Impidimp Builder only waiting for a Level
		/// </summary>
		public ImpidimpInstance(int level)
		: base(
				SpeciesImpidimp.Instance, // PokemonInstance Species
				"Impidimp", level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Impidimp Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ImpidimpInstance() : base(
			SpeciesImpidimp.Instance, // PokemonInstance Species
			Dark.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}