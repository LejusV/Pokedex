using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Helioptile Specie to store common natural stats of all Helioptiles
	#region SpecieHelioptile
	public class SpecieHelioptile : PokemonSpecie
	{
#nullable enable
		private static SpecieHelioptile? _instance = null;
#nullable restore
        public static SpecieHelioptile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHelioptile();
                }
                return _instance;
            }
        }

		#region SpecieHelioptile Builder
		public SpecieHelioptile() : base(
			"Helioptile",
			44, // HPs
			38, 33, // Attack & Defense
			61, 43, // Special Attack & Defense
			70		
		)
		{
			this._height = 5;
			this._weight = 60;
		}
		#endregion
	}
	#endregion

	//Helioptile Pokemon Class
	#region Helioptile
	public class Helioptile : Pokemon
	{
		#region Helioptile Builders
		/// <summary>
		/// Helioptile Builder waiting for a Nickname & a Level
		/// </summary>
		public Helioptile(string nickname, int level)
		: base(
				694,
				SpecieHelioptile.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Helioptile Builder only waiting for a Level
		/// </summary>
		public Helioptile(int level)
		: base(
				694,
				SpecieHelioptile.Instance, // Pokemon Specie
				"Helioptile", level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Helioptile Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Helioptile() : base(
			694,
			SpecieHelioptile.Instance, // Pokemon Specie
			Electric.Instance, Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}