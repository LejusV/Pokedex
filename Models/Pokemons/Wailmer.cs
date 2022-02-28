using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wailmer Specie to store common natural stats of all Wailmers
	#region SpecieWailmer
	public class SpecieWailmer : PokemonSpecie
	{
#nullable enable
		private static SpecieWailmer? _instance = null;
#nullable restore
        public static SpecieWailmer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWailmer();
                }
                return _instance;
            }
        }

		#region SpecieWailmer Builder
		public SpecieWailmer() : base(
			"Wailmer",
			130, // HPs
			70, 35, // Attack & Defense
			70, 35, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Wailmer Pokemon Class
	#region Wailmer
	public class Wailmer : Pokemon
	{
		#region Wailmer Builders
		/// <summary>
		/// Wailmer Builder waiting for a Nickname & a Level
		/// </summary>
		public Wailmer(string nickname, int level)
		: base(
				320,
				SpecieWailmer.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailmer Builder only waiting for a Level
		/// </summary>
		public Wailmer(int level)
		: base(
				320,
				SpecieWailmer.Instance, // Pokemon Specie
				"Wailmer", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailmer Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Wailmer() : base(
			320,
			SpecieWailmer.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}