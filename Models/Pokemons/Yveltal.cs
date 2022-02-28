using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Yveltal Specie to store common natural stats of all Yveltals
	#region SpecieYveltal
	public class SpecieYveltal : PokemonSpecie
	{
#nullable enable
		private static SpecieYveltal? _instance = null;
#nullable restore
        public static SpecieYveltal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYveltal();
                }
                return _instance;
            }
        }

		#region SpecieYveltal Builder
		public SpecieYveltal() : base(
			"Yveltal",
			126, // HPs
			131, 95, // Attack & Defense
			131, 98, // Special Attack & Defense
			99			
		) {}
		#endregion
	}
	#endregion

	//Yveltal Pokemon Class
	#region Yveltal
	public class Yveltal : Pokemon
	{
		#region Yveltal Builders
		/// <summary>
		/// Yveltal Builder waiting for a Nickname & a Level
		/// </summary>
		public Yveltal(string nickname, int level)
		: base(
				717,
				SpecieYveltal.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yveltal Builder only waiting for a Level
		/// </summary>
		public Yveltal(int level)
		: base(
				717,
				SpecieYveltal.Instance, // Pokemon Specie
				"Yveltal", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yveltal Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Yveltal() : base(
			717,
			SpecieYveltal.Instance, // Pokemon Specie
			Dark.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}