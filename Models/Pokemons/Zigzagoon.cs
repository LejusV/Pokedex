using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Zigzagoon Specie to store common natural stats of all Zigzagoons
	#region SpecieZigzagoon
	public class SpecieZigzagoon : PokemonSpecie
	{
#nullable enable
		private static SpecieZigzagoon? _instance = null;
#nullable restore
        public static SpecieZigzagoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZigzagoon();
                }
                return _instance;
            }
        }

		#region SpecieZigzagoon Builder
		public SpecieZigzagoon() : base(
			"Zigzagoon",
			38, // HPs
			30, 41, // Attack & Defense
			30, 41, // Special Attack & Defense
			60		
		)
		{
			this._height = 4;
			this._weight = 175;
		}
		#endregion
	}
	#endregion

	//Zigzagoon Pokemon Class
	#region Zigzagoon
	public class Zigzagoon : Pokemon
	{
		#region Zigzagoon Builders
		/// <summary>
		/// Zigzagoon Builder waiting for a Nickname & a Level
		/// </summary>
		public Zigzagoon(string nickname, int level)
		: base(
				263,
				SpecieZigzagoon.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zigzagoon Builder only waiting for a Level
		/// </summary>
		public Zigzagoon(int level)
		: base(
				263,
				SpecieZigzagoon.Instance, // Pokemon Specie
				"Zigzagoon", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zigzagoon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Zigzagoon() : base(
			263,
			SpecieZigzagoon.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}