using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Persian Specie to store common natural stats of all Persians
	#region SpeciePersian
	public class SpeciePersian : PokemonSpecie
	{
#nullable enable
		private static SpeciePersian? _instance = null;
#nullable restore
        public static SpeciePersian Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePersian();
                }
                return _instance;
            }
        }

		#region SpeciePersian Builder
		public SpeciePersian() : base(
			"Persian",
			65, // HPs
			70, 60, // Attack & Defense
			65, 65, // Special Attack & Defense
			115			
		) {}
		#endregion
	}
	#endregion

	//Persian Pokemon Class
	#region Persian
	public class Persian : Pokemon
	{
		#region Persian Builders
		/// <summary>
		/// Persian Builder waiting for a Nickname & a Level
		/// </summary>
		public Persian(string nickname, int level)
		: base(
				53,
				SpeciePersian.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Persian Builder only waiting for a Level
		/// </summary>
		public Persian(int level)
		: base(
				53,
				SpeciePersian.Instance, // Pokemon Specie
				"Persian", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Persian Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Persian() : base(
			53,
			SpeciePersian.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}