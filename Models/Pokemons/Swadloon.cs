using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Swadloon Specie to store common natural stats of all Swadloons
	#region SpecieSwadloon
	public class SpecieSwadloon : PokemonSpecie
	{
#nullable enable
		private static SpecieSwadloon? _instance = null;
#nullable restore
        public static SpecieSwadloon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwadloon();
                }
                return _instance;
            }
        }

		#region SpecieSwadloon Builder
		public SpecieSwadloon() : base(
			"Swadloon",
			0.5,
			7.3,
			55, // HPs
			63, 90, // Attack & Defense
			50, 80, // Special Attack & Defense
			42		
		)
		{}
		#endregion
	}
	#endregion

	//Swadloon Pokemon Class
	#region Swadloon
	public class Swadloon : Pokemon
	{
		#region Swadloon Builders
		/// <summary>
		/// Swadloon Builder waiting for a Nickname & a Level
		/// </summary>
		public Swadloon(string nickname, int level)
		: base(
				541,
				SpecieSwadloon.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swadloon Builder only waiting for a Level
		/// </summary>
		public Swadloon(int level)
		: base(
				541,
				SpecieSwadloon.Instance, // Pokemon Specie
				"Swadloon", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swadloon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Swadloon() : base(
			541,
			SpecieSwadloon.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}