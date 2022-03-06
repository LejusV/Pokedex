using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Bulu Specie to store common natural stats of all Tapu-Bulus
	#region SpecieTapu-Bulu
	public class SpecieTapuBulu : PokemonSpecie
	{
#nullable enable
		private static SpecieTapuBulu? _instance = null;
#nullable restore
        public static SpecieTapuBulu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTapuBulu();
                }
                return _instance;
            }
        }

		#region SpecieTapu-Bulu Builder
		public SpecieTapuBulu() : base(
			"Tapu-Bulu",
			70, // HPs
			130, 115, // Attack & Defense
			85, 95, // Special Attack & Defense
			75		
		)
		{
			this._height = 19;
			this._weight = 455;
		}
		#endregion
	}
	#endregion

	//Tapu-Bulu Pokemon Class
	#region Tapu-Bulu
	public class TapuBulu : Pokemon
	{
		#region Tapu-Bulu Builders
		/// <summary>
		/// Tapu-Bulu Builder waiting for a Nickname & a Level
		/// </summary>
		public TapuBulu(string nickname, int level)
		: base(
				787,
				SpecieTapuBulu.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Bulu Builder only waiting for a Level
		/// </summary>
		public TapuBulu(int level)
		: base(
				787,
				SpecieTapuBulu.Instance, // Pokemon Specie
				"Tapu-Bulu", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Bulu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public TapuBulu() : base(
			787,
			SpecieTapuBulu.Instance, // Pokemon Specie
			Grass.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}