using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Komala Specie to store common natural stats of all Komalas
	#region SpecieKomala
	public class SpecieKomala : PokemonSpecie
	{
#nullable enable
		private static SpecieKomala? _instance = null;
#nullable restore
        public static SpecieKomala Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKomala();
                }
                return _instance;
            }
        }

		#region SpecieKomala Builder
		public SpecieKomala() : base(
			"Komala",
			65, // HPs
			115, 65, // Attack & Defense
			75, 95, // Special Attack & Defense
			65		
		)
		{
			this._height = 4;
			this._weight = 199;
		}
		#endregion
	}
	#endregion

	//Komala Pokemon Class
	#region Komala
	public class Komala : Pokemon
	{
		#region Komala Builders
		/// <summary>
		/// Komala Builder waiting for a Nickname & a Level
		/// </summary>
		public Komala(string nickname, int level)
		: base(
				775,
				SpecieKomala.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Komala Builder only waiting for a Level
		/// </summary>
		public Komala(int level)
		: base(
				775,
				SpecieKomala.Instance, // Pokemon Specie
				"Komala", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Komala Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Komala() : base(
			775,
			SpecieKomala.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}