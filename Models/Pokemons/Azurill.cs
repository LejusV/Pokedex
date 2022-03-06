using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Azurill Specie to store common natural stats of all Azurills
	#region SpecieAzurill
	public class SpecieAzurill : PokemonSpecie
	{
#nullable enable
		private static SpecieAzurill? _instance = null;
#nullable restore
        public static SpecieAzurill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAzurill();
                }
                return _instance;
            }
        }

		#region SpecieAzurill Builder
		public SpecieAzurill() : base(
			"Azurill",
			50, // HPs
			20, 40, // Attack & Defense
			20, 40, // Special Attack & Defense
			20		
		)
		{
			this._height = 2;
			this._weight = 20;
		}
		#endregion
	}
	#endregion

	//Azurill Pokemon Class
	#region Azurill
	public class Azurill : Pokemon
	{
		#region Azurill Builders
		/// <summary>
		/// Azurill Builder waiting for a Nickname & a Level
		/// </summary>
		public Azurill(string nickname, int level)
		: base(
				298,
				SpecieAzurill.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azurill Builder only waiting for a Level
		/// </summary>
		public Azurill(int level)
		: base(
				298,
				SpecieAzurill.Instance, // Pokemon Specie
				"Azurill", level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azurill Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Azurill() : base(
			298,
			SpecieAzurill.Instance, // Pokemon Specie
			Normal.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}