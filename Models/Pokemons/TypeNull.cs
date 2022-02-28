using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Type-Null Specie to store common natural stats of all Type-Nulls
	#region SpecieType-Null
	public class SpecieTypeNull : PokemonSpecie
	{
#nullable enable
		private static SpecieTypeNull? _instance = null;
#nullable restore
        public static SpecieTypeNull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTypeNull();
                }
                return _instance;
            }
        }

		#region SpecieType-Null Builder
		public SpecieTypeNull() : base(
			"Type-Null",
			95, // HPs
			95, 95, // Attack & Defense
			95, 95, // Special Attack & Defense
			59			
		) {}
		#endregion
	}
	#endregion

	//Type-Null Pokemon Class
	#region Type-Null
	public class TypeNull : Pokemon
	{
		#region Type-Null Builders
		/// <summary>
		/// Type-Null Builder waiting for a Nickname & a Level
		/// </summary>
		public TypeNull(string nickname, int level)
		: base(
				772,
				SpecieTypeNull.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Type-Null Builder only waiting for a Level
		/// </summary>
		public TypeNull(int level)
		: base(
				772,
				SpecieTypeNull.Instance, // Pokemon Specie
				"Type-Null", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Type-Null Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public TypeNull() : base(
			772,
			SpecieTypeNull.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}