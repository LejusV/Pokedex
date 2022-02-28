using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Emolga Specie to store common natural stats of all Emolgas
	#region SpecieEmolga
	public class SpecieEmolga : PokemonSpecie
	{
#nullable enable
		private static SpecieEmolga? _instance = null;
#nullable restore
        public static SpecieEmolga Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEmolga();
                }
                return _instance;
            }
        }

		#region SpecieEmolga Builder
		public SpecieEmolga() : base(
			"Emolga",
			55, // HPs
			75, 60, // Attack & Defense
			75, 60, // Special Attack & Defense
			103			
		) {}
		#endregion
	}
	#endregion

	//Emolga Pokemon Class
	#region Emolga
	public class Emolga : Pokemon
	{
		#region Emolga Builders
		/// <summary>
		/// Emolga Builder waiting for a Nickname & a Level
		/// </summary>
		public Emolga(string nickname, int level)
		: base(
				587,
				SpecieEmolga.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emolga Builder only waiting for a Level
		/// </summary>
		public Emolga(int level)
		: base(
				587,
				SpecieEmolga.Instance, // Pokemon Specie
				"Emolga", level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emolga Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Emolga() : base(
			587,
			SpecieEmolga.Instance, // Pokemon Specie
			Electric.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}