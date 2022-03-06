using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Raikou Specie to store common natural stats of all Raikous
	#region SpecieRaikou
	public class SpecieRaikou : PokemonSpecie
	{
#nullable enable
		private static SpecieRaikou? _instance = null;
#nullable restore
        public static SpecieRaikou Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRaikou();
                }
                return _instance;
            }
        }

		#region SpecieRaikou Builder
		public SpecieRaikou() : base(
			"Raikou",
			90, // HPs
			85, 75, // Attack & Defense
			115, 100, // Special Attack & Defense
			115		
		)
		{
			this._height = 19;
			this._weight = 1780;
		}
		#endregion
	}
	#endregion

	//Raikou Pokemon Class
	#region Raikou
	public class Raikou : Pokemon
	{
		#region Raikou Builders
		/// <summary>
		/// Raikou Builder waiting for a Nickname & a Level
		/// </summary>
		public Raikou(string nickname, int level)
		: base(
				243,
				SpecieRaikou.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raikou Builder only waiting for a Level
		/// </summary>
		public Raikou(int level)
		: base(
				243,
				SpecieRaikou.Instance, // Pokemon Specie
				"Raikou", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raikou Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Raikou() : base(
			243,
			SpecieRaikou.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}