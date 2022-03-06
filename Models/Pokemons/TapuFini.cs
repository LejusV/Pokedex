using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Fini Specie to store common natural stats of all Tapu-Finis
	#region SpecieTapu-Fini
	public class SpecieTapuFini : PokemonSpecie
	{
#nullable enable
		private static SpecieTapuFini? _instance = null;
#nullable restore
        public static SpecieTapuFini Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTapuFini();
                }
                return _instance;
            }
        }

		#region SpecieTapu-Fini Builder
		public SpecieTapuFini() : base(
			"Tapu-Fini",
			1.3,
			21.2,
			70, // HPs
			75, 115, // Attack & Defense
			95, 130, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Tapu-Fini Pokemon Class
	#region Tapu-Fini
	public class TapuFini : Pokemon
	{
		#region Tapu-Fini Builders
		/// <summary>
		/// Tapu-Fini Builder waiting for a Nickname & a Level
		/// </summary>
		public TapuFini(string nickname, int level)
		: base(
				788,
				SpecieTapuFini.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Fini Builder only waiting for a Level
		/// </summary>
		public TapuFini(int level)
		: base(
				788,
				SpecieTapuFini.Instance, // Pokemon Specie
				"Tapu-Fini", level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Fini Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public TapuFini() : base(
			788,
			SpecieTapuFini.Instance, // Pokemon Specie
			Water.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}