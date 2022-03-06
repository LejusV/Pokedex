using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Koko Specie to store common natural stats of all Tapu-Kokos
	#region SpecieTapu-Koko
	public class SpecieTapuKoko : PokemonSpecie
	{
#nullable enable
		private static SpecieTapuKoko? _instance = null;
#nullable restore
        public static SpecieTapuKoko Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTapuKoko();
                }
                return _instance;
            }
        }

		#region SpecieTapu-Koko Builder
		public SpecieTapuKoko() : base(
			"Tapu-Koko",
			70, // HPs
			115, 85, // Attack & Defense
			95, 75, // Special Attack & Defense
			130		
		)
		{
			this._height = 18;
			this._weight = 205;
		}
		#endregion
	}
	#endregion

	//Tapu-Koko Pokemon Class
	#region Tapu-Koko
	public class TapuKoko : Pokemon
	{
		#region Tapu-Koko Builders
		/// <summary>
		/// Tapu-Koko Builder waiting for a Nickname & a Level
		/// </summary>
		public TapuKoko(string nickname, int level)
		: base(
				785,
				SpecieTapuKoko.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Koko Builder only waiting for a Level
		/// </summary>
		public TapuKoko(int level)
		: base(
				785,
				SpecieTapuKoko.Instance, // Pokemon Specie
				"Tapu-Koko", level,
				Electric.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Koko Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public TapuKoko() : base(
			785,
			SpecieTapuKoko.Instance, // Pokemon Specie
			Electric.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}