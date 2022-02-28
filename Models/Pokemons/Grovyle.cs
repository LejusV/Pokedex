using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grovyle Specie to store common natural stats of all Grovyles
	#region SpecieGrovyle
	public class SpecieGrovyle : PokemonSpecie
	{
#nullable enable
		private static SpecieGrovyle? _instance = null;
#nullable restore
        public static SpecieGrovyle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrovyle();
                }
                return _instance;
            }
        }

		#region SpecieGrovyle Builder
		public SpecieGrovyle() : base(
			"Grovyle",
			50, // HPs
			65, 45, // Attack & Defense
			85, 65, // Special Attack & Defense
			95			
		) {}
		#endregion
	}
	#endregion

	//Grovyle Pokemon Class
	#region Grovyle
	public class Grovyle : Pokemon
	{
		#region Grovyle Builders
		/// <summary>
		/// Grovyle Builder waiting for a Nickname & a Level
		/// </summary>
		public Grovyle(string nickname, int level)
		: base(
				253,
				SpecieGrovyle.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grovyle Builder only waiting for a Level
		/// </summary>
		public Grovyle(int level)
		: base(
				253,
				SpecieGrovyle.Instance, // Pokemon Specie
				"Grovyle", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grovyle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Grovyle() : base(
			253,
			SpecieGrovyle.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}