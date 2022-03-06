using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Doduo Specie to store common natural stats of all Doduos
	#region SpecieDoduo
	public class SpecieDoduo : PokemonSpecie
	{
#nullable enable
		private static SpecieDoduo? _instance = null;
#nullable restore
        public static SpecieDoduo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDoduo();
                }
                return _instance;
            }
        }

		#region SpecieDoduo Builder
		public SpecieDoduo() : base(
			"Doduo",
			35, // HPs
			85, 45, // Attack & Defense
			35, 35, // Special Attack & Defense
			75		
		)
		{
			this._height = 14;
			this._weight = 392;
		}
		#endregion
	}
	#endregion

	//Doduo Pokemon Class
	#region Doduo
	public class Doduo : Pokemon
	{
		#region Doduo Builders
		/// <summary>
		/// Doduo Builder waiting for a Nickname & a Level
		/// </summary>
		public Doduo(string nickname, int level)
		: base(
				84,
				SpecieDoduo.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doduo Builder only waiting for a Level
		/// </summary>
		public Doduo(int level)
		: base(
				84,
				SpecieDoduo.Instance, // Pokemon Specie
				"Doduo", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doduo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Doduo() : base(
			84,
			SpecieDoduo.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}