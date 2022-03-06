using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kyurem Specie to store common natural stats of all Kyurems
	#region SpecieKyurem
	public class SpecieKyurem : PokemonSpecie
	{
#nullable enable
		private static SpecieKyurem? _instance = null;
#nullable restore
        public static SpecieKyurem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKyurem();
                }
                return _instance;
            }
        }

		#region SpecieKyurem Builder
		public SpecieKyurem() : base(
			"Kyurem",
			125, // HPs
			130, 90, // Attack & Defense
			130, 90, // Special Attack & Defense
			95		
		)
		{
			this._height = 30;
			this._weight = 3250;
		}
		#endregion
	}
	#endregion

	//Kyurem Pokemon Class
	#region Kyurem
	public class Kyurem : Pokemon
	{
		#region Kyurem Builders
		/// <summary>
		/// Kyurem Builder waiting for a Nickname & a Level
		/// </summary>
		public Kyurem(string nickname, int level)
		: base(
				646,
				SpecieKyurem.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyurem Builder only waiting for a Level
		/// </summary>
		public Kyurem(int level)
		: base(
				646,
				SpecieKyurem.Instance, // Pokemon Specie
				"Kyurem", level,
				Dragon.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyurem Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kyurem() : base(
			646,
			SpecieKyurem.Instance, // Pokemon Specie
			Dragon.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}