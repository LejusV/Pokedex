using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hydreigon Specie to store common natural stats of all Hydreigons
	#region SpecieHydreigon
	public class SpecieHydreigon : PokemonSpecie
	{
#nullable enable
		private static SpecieHydreigon? _instance = null;
#nullable restore
        public static SpecieHydreigon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHydreigon();
                }
                return _instance;
            }
        }

		#region SpecieHydreigon Builder
		public SpecieHydreigon() : base(
			"Hydreigon",
			92, // HPs
			105, 90, // Attack & Defense
			125, 90, // Special Attack & Defense
			98			
		) {}
		#endregion
	}
	#endregion

	//Hydreigon Pokemon Class
	#region Hydreigon
	public class Hydreigon : Pokemon
	{
		#region Hydreigon Builders
		/// <summary>
		/// Hydreigon Builder waiting for a Nickname & a Level
		/// </summary>
		public Hydreigon(string nickname, int level)
		: base(
				635,
				SpecieHydreigon.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hydreigon Builder only waiting for a Level
		/// </summary>
		public Hydreigon(int level)
		: base(
				635,
				SpecieHydreigon.Instance, // Pokemon Specie
				"Hydreigon", level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hydreigon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Hydreigon() : base(
			635,
			SpecieHydreigon.Instance, // Pokemon Specie
			Dark.Instance, Dragon.Instance			
		) {}
		#endregion
	}
	#endregion
}