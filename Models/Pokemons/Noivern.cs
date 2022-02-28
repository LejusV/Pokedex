using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Noivern Specie to store common natural stats of all Noiverns
	#region SpecieNoivern
	public class SpecieNoivern : PokemonSpecie
	{
#nullable enable
		private static SpecieNoivern? _instance = null;
#nullable restore
        public static SpecieNoivern Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNoivern();
                }
                return _instance;
            }
        }

		#region SpecieNoivern Builder
		public SpecieNoivern() : base(
			"Noivern",
			85, // HPs
			70, 80, // Attack & Defense
			97, 80, // Special Attack & Defense
			123			
		) {}
		#endregion
	}
	#endregion

	//Noivern Pokemon Class
	#region Noivern
	public class Noivern : Pokemon
	{
		#region Noivern Builders
		/// <summary>
		/// Noivern Builder waiting for a Nickname & a Level
		/// </summary>
		public Noivern(string nickname, int level)
		: base(
				715,
				SpecieNoivern.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noivern Builder only waiting for a Level
		/// </summary>
		public Noivern(int level)
		: base(
				715,
				SpecieNoivern.Instance, // Pokemon Specie
				"Noivern", level,
				Flying.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noivern Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Noivern() : base(
			715,
			SpecieNoivern.Instance, // Pokemon Specie
			Flying.Instance, Dragon.Instance			
		) {}
		#endregion
	}
	#endregion
}