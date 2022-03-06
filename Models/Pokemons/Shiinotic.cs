using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Shiinotic Specie to store common natural stats of all Shiinotics
	#region SpecieShiinotic
	public class SpecieShiinotic : PokemonSpecie
	{
#nullable enable
		private static SpecieShiinotic? _instance = null;
#nullable restore
        public static SpecieShiinotic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShiinotic();
                }
                return _instance;
            }
        }

		#region SpecieShiinotic Builder
		public SpecieShiinotic() : base(
			"Shiinotic",
			60, // HPs
			45, 80, // Attack & Defense
			90, 100, // Special Attack & Defense
			30		
		)
		{
			this._height = 10;
			this._weight = 115;
		}
		#endregion
	}
	#endregion

	//Shiinotic Pokemon Class
	#region Shiinotic
	public class Shiinotic : Pokemon
	{
		#region Shiinotic Builders
		/// <summary>
		/// Shiinotic Builder waiting for a Nickname & a Level
		/// </summary>
		public Shiinotic(string nickname, int level)
		: base(
				756,
				SpecieShiinotic.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiinotic Builder only waiting for a Level
		/// </summary>
		public Shiinotic(int level)
		: base(
				756,
				SpecieShiinotic.Instance, // Pokemon Specie
				"Shiinotic", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiinotic Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Shiinotic() : base(
			756,
			SpecieShiinotic.Instance, // Pokemon Specie
			Grass.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}