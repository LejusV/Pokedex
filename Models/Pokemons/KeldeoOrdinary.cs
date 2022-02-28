using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Keldeo-Ordinary Specie to store common natural stats of all Keldeo-Ordinarys
	#region SpecieKeldeo-Ordinary
	public class SpecieKeldeoOrdinary : PokemonSpecie
	{
#nullable enable
		private static SpecieKeldeoOrdinary? _instance = null;
#nullable restore
        public static SpecieKeldeoOrdinary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKeldeoOrdinary();
                }
                return _instance;
            }
        }

		#region SpecieKeldeo-Ordinary Builder
		public SpecieKeldeoOrdinary() : base(
			"Keldeo-Ordinary",
			91, // HPs
			72, 90, // Attack & Defense
			129, 90, // Special Attack & Defense
			108			
		) {}
		#endregion
	}
	#endregion

	//Keldeo-Ordinary Pokemon Class
	#region Keldeo-Ordinary
	public class KeldeoOrdinary : Pokemon
	{
		#region Keldeo-Ordinary Builders
		/// <summary>
		/// Keldeo-Ordinary Builder waiting for a Nickname & a Level
		/// </summary>
		public KeldeoOrdinary(string nickname, int level)
		: base(
				647,
				SpecieKeldeoOrdinary.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Keldeo-Ordinary Builder only waiting for a Level
		/// </summary>
		public KeldeoOrdinary(int level)
		: base(
				647,
				SpecieKeldeoOrdinary.Instance, // Pokemon Specie
				"Keldeo-Ordinary", level,
				Water.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Keldeo-Ordinary Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public KeldeoOrdinary() : base(
			647,
			SpecieKeldeoOrdinary.Instance, // Pokemon Specie
			Water.Instance, Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}