using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Klefki Specie to store common natural stats of all Klefkis
	#region SpecieKlefki
	public class SpecieKlefki : PokemonSpecie
	{
#nullable enable
		private static SpecieKlefki? _instance = null;
#nullable restore
        public static SpecieKlefki Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKlefki();
                }
                return _instance;
            }
        }

		#region SpecieKlefki Builder
		public SpecieKlefki() : base(
			"Klefki",
			57, // HPs
			80, 91, // Attack & Defense
			80, 87, // Special Attack & Defense
			75		
		)
		{
			this._height = 2;
			this._weight = 30;
		}
		#endregion
	}
	#endregion

	//Klefki Pokemon Class
	#region Klefki
	public class Klefki : Pokemon
	{
		#region Klefki Builders
		/// <summary>
		/// Klefki Builder waiting for a Nickname & a Level
		/// </summary>
		public Klefki(string nickname, int level)
		: base(
				707,
				SpecieKlefki.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klefki Builder only waiting for a Level
		/// </summary>
		public Klefki(int level)
		: base(
				707,
				SpecieKlefki.Instance, // Pokemon Specie
				"Klefki", level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klefki Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Klefki() : base(
			707,
			SpecieKlefki.Instance, // Pokemon Specie
			Steel.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}