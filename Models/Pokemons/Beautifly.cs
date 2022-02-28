using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Beautifly Specie to store common natural stats of all Beautiflys
	#region SpecieBeautifly
	public class SpecieBeautifly : PokemonSpecie
	{
#nullable enable
		private static SpecieBeautifly? _instance = null;
#nullable restore
        public static SpecieBeautifly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBeautifly();
                }
                return _instance;
            }
        }

		#region SpecieBeautifly Builder
		public SpecieBeautifly() : base(
			"Beautifly",
			60, // HPs
			70, 50, // Attack & Defense
			100, 50, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Beautifly Pokemon Class
	#region Beautifly
	public class Beautifly : Pokemon
	{
		#region Beautifly Builders
		/// <summary>
		/// Beautifly Builder waiting for a Nickname & a Level
		/// </summary>
		public Beautifly(string nickname, int level)
		: base(
				267,
				SpecieBeautifly.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beautifly Builder only waiting for a Level
		/// </summary>
		public Beautifly(int level)
		: base(
				267,
				SpecieBeautifly.Instance, // Pokemon Specie
				"Beautifly", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beautifly Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Beautifly() : base(
			267,
			SpecieBeautifly.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}