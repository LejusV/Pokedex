using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Obstagoon Species to store common natural stats of all Obstagoons
	#region SpeciesObstagoon
	public class SpeciesObstagoon : PokemonSpecies
	{
#nullable enable
		private static SpeciesObstagoon? _instance = null;
#nullable restore
        public static SpeciesObstagoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesObstagoon();
                }
                return _instance;
            }
        }

		#region SpeciesObstagoon Constructor
		public SpeciesObstagoon() : base(
			"Obstagoon",
			1.6,
			46.0,
			93, // HPs
			90, 101, // Attack & Defense
			60, 81, // Special Attack & Defense
			95		
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

	//Obstagoon PokemonInstance Class
	#region Obstagoon
	public class ObstagoonInstance : PokemonInstance
	{
		#region Obstagoon Constructors
		/// <summary>
		/// Obstagoon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ObstagoonInstance(string nickname, int level)
		: base(
				862,
				SpeciesObstagoon.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Obstagoon Builder only waiting for a Level
		/// </summary>
		public ObstagoonInstance(int level)
		: base(
				862,
				SpeciesObstagoon.Instance, // PokemonInstance Species
				"Obstagoon", level,
				Dark.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Obstagoon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Obstagoon() : base(
			862,
			SpeciesObstagoon.Instance, // PokemonInstance Species
			Dark.Instance, Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}