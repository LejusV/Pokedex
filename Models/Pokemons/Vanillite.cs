using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Vanillite Specie to store common natural stats of all Vanillites
	#region SpecieVanillite
	public class SpecieVanillite : PokemonSpecie
	{
#nullable enable
		private static SpecieVanillite? _instance = null;
#nullable restore
        public static SpecieVanillite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVanillite();
                }
                return _instance;
            }
        }

		#region SpecieVanillite Builder
		public SpecieVanillite() : base(
			"Vanillite",
			36, // HPs
			50, 50, // Attack & Defense
			65, 60, // Special Attack & Defense
			44		
		)
		{
			this._height = 4;
			this._weight = 57;
		}
		#endregion
	}
	#endregion

	//Vanillite Pokemon Class
	#region Vanillite
	public class Vanillite : Pokemon
	{
		#region Vanillite Builders
		/// <summary>
		/// Vanillite Builder waiting for a Nickname & a Level
		/// </summary>
		public Vanillite(string nickname, int level)
		: base(
				582,
				SpecieVanillite.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillite Builder only waiting for a Level
		/// </summary>
		public Vanillite(int level)
		: base(
				582,
				SpecieVanillite.Instance, // Pokemon Specie
				"Vanillite", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillite Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Vanillite() : base(
			582,
			SpecieVanillite.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}