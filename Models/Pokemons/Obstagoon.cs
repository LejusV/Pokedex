using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Obstagoon Specie to store common natural stats of all Obstagoons
	#region SpecieObstagoon
	public class SpecieObstagoon : PokemonSpecie
	{
#nullable enable
		private static SpecieObstagoon? _instance = null;
#nullable restore
        public static SpecieObstagoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieObstagoon();
                }
                return _instance;
            }
        }

		#region SpecieObstagoon Builder
		public SpecieObstagoon() : base(
			"Obstagoon",
			93, // HPs
			90, 101, // Attack & Defense
			60, 81, // Special Attack & Defense
			95		
		)
		{
			this._height = 16;
			this._weight = 460;
		}
		#endregion
	}
	#endregion

	//Obstagoon Pokemon Class
	#region Obstagoon
	public class Obstagoon : Pokemon
	{
		#region Obstagoon Builders
		/// <summary>
		/// Obstagoon Builder waiting for a Nickname & a Level
		/// </summary>
		public Obstagoon(string nickname, int level)
		: base(
				862,
				SpecieObstagoon.Instance, // Pokemon Specie
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
		public Obstagoon(int level)
		: base(
				862,
				SpecieObstagoon.Instance, // Pokemon Specie
				"Obstagoon", level,
				Dark.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Obstagoon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Obstagoon() : base(
			862,
			SpecieObstagoon.Instance, // Pokemon Specie
			Dark.Instance, Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}