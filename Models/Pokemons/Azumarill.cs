using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Azumarill Specie to store common natural stats of all Azumarills
	#region SpecieAzumarill
	public class SpecieAzumarill : PokemonSpecie
	{
#nullable enable
		private static SpecieAzumarill? _instance = null;
#nullable restore
        public static SpecieAzumarill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAzumarill();
                }
                return _instance;
            }
        }

		#region SpecieAzumarill Builder
		public SpecieAzumarill() : base(
			"Azumarill",
			100, // HPs
			50, 80, // Attack & Defense
			60, 80, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Azumarill Pokemon Class
	#region Azumarill
	public class Azumarill : Pokemon
	{
		#region Azumarill Builders
		/// <summary>
		/// Azumarill Builder waiting for a Nickname & a Level
		/// </summary>
		public Azumarill(string nickname, int level)
		: base(
				184,
				SpecieAzumarill.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azumarill Builder only waiting for a Level
		/// </summary>
		public Azumarill(int level)
		: base(
				184,
				SpecieAzumarill.Instance, // Pokemon Specie
				"Azumarill", level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azumarill Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Azumarill() : base(
			184,
			SpecieAzumarill.Instance, // Pokemon Specie
			Water.Instance, Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}