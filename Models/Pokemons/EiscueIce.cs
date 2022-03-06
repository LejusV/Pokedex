using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Eiscue-Ice Specie to store common natural stats of all Eiscue-Ices
	#region SpecieEiscue-Ice
	public class SpecieEiscueIce : PokemonSpecie
	{
#nullable enable
		private static SpecieEiscueIce? _instance = null;
#nullable restore
        public static SpecieEiscueIce Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEiscueIce();
                }
                return _instance;
            }
        }

		#region SpecieEiscue-Ice Builder
		public SpecieEiscueIce() : base(
			"Eiscue-Ice",
			75, // HPs
			80, 110, // Attack & Defense
			65, 90, // Special Attack & Defense
			50		
		)
		{
			this._height = 14;
			this._weight = 890;
		}
		#endregion
	}
	#endregion

	//Eiscue-Ice Pokemon Class
	#region Eiscue-Ice
	public class EiscueIce : Pokemon
	{
		#region Eiscue-Ice Builders
		/// <summary>
		/// Eiscue-Ice Builder waiting for a Nickname & a Level
		/// </summary>
		public EiscueIce(string nickname, int level)
		: base(
				875,
				SpecieEiscueIce.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eiscue-Ice Builder only waiting for a Level
		/// </summary>
		public EiscueIce(int level)
		: base(
				875,
				SpecieEiscueIce.Instance, // Pokemon Specie
				"Eiscue-Ice", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eiscue-Ice Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public EiscueIce() : base(
			875,
			SpecieEiscueIce.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}