using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Weedle Specie to store common natural stats of all Weedles
	#region SpecieWeedle
	public class SpecieWeedle : PokemonSpecie
	{
#nullable enable
		private static SpecieWeedle? _instance = null;
#nullable restore
        public static SpecieWeedle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWeedle();
                }
                return _instance;
            }
        }

		#region SpecieWeedle Builder
		public SpecieWeedle() : base(
			"Weedle",
			40, // HPs
			35, 30, // Attack & Defense
			20, 20, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Weedle Pokemon Class
	#region Weedle
	public class Weedle : Pokemon
	{
		#region Weedle Builders
		/// <summary>
		/// Weedle Builder waiting for a Nickname & a Level
		/// </summary>
		public Weedle(string nickname, int level)
		: base(
				13,
				SpecieWeedle.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weedle Builder only waiting for a Level
		/// </summary>
		public Weedle(int level)
		: base(
				13,
				SpecieWeedle.Instance, // Pokemon Specie
				"Weedle", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weedle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Weedle() : base(
			13,
			SpecieWeedle.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}