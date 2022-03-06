using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Lele Specie to store common natural stats of all Tapu-Leles
	#region SpecieTapu-Lele
	public class SpecieTapuLele : PokemonSpecie
	{
#nullable enable
		private static SpecieTapuLele? _instance = null;
#nullable restore
        public static SpecieTapuLele Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTapuLele();
                }
                return _instance;
            }
        }

		#region SpecieTapu-Lele Builder
		public SpecieTapuLele() : base(
			"Tapu-Lele",
			1.2,
			18.6,
			70, // HPs
			85, 75, // Attack & Defense
			130, 115, // Special Attack & Defense
			95		
		)
		{}
		#endregion
	}
	#endregion

	//Tapu-Lele Pokemon Class
	#region Tapu-Lele
	public class TapuLele : Pokemon
	{
		#region Tapu-Lele Builders
		/// <summary>
		/// Tapu-Lele Builder waiting for a Nickname & a Level
		/// </summary>
		public TapuLele(string nickname, int level)
		: base(
				786,
				SpecieTapuLele.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Lele Builder only waiting for a Level
		/// </summary>
		public TapuLele(int level)
		: base(
				786,
				SpecieTapuLele.Instance, // Pokemon Specie
				"Tapu-Lele", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Lele Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public TapuLele() : base(
			786,
			SpecieTapuLele.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}