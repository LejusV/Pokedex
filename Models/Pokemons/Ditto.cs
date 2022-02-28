using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ditto Specie to store common natural stats of all Dittos
	#region SpecieDitto
	public class SpecieDitto : PokemonSpecie
	{
#nullable enable
		private static SpecieDitto? _instance = null;
#nullable restore
        public static SpecieDitto Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDitto();
                }
                return _instance;
            }
        }

		#region SpecieDitto Builder
		public SpecieDitto() : base(
			"Ditto",
			48, // HPs
			48, 48, // Attack & Defense
			48, 48, // Special Attack & Defense
			48			
		) {}
		#endregion
	}
	#endregion

	//Ditto Pokemon Class
	#region Ditto
	public class Ditto : Pokemon
	{
		#region Ditto Builders
		/// <summary>
		/// Ditto Builder waiting for a Nickname & a Level
		/// </summary>
		public Ditto(string nickname, int level)
		: base(
				132,
				SpecieDitto.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ditto Builder only waiting for a Level
		/// </summary>
		public Ditto(int level)
		: base(
				132,
				SpecieDitto.Instance, // Pokemon Specie
				"Ditto", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ditto Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Ditto() : base(
			132,
			SpecieDitto.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}