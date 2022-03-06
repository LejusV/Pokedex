using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Stoutland Specie to store common natural stats of all Stoutlands
	#region SpecieStoutland
	public class SpecieStoutland : PokemonSpecie
	{
#nullable enable
		private static SpecieStoutland? _instance = null;
#nullable restore
        public static SpecieStoutland Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStoutland();
                }
                return _instance;
            }
        }

		#region SpecieStoutland Builder
		public SpecieStoutland() : base(
			"Stoutland",
			85, // HPs
			110, 90, // Attack & Defense
			45, 90, // Special Attack & Defense
			80		
		)
		{
			this._height = 12;
			this._weight = 610;
		}
		#endregion
	}
	#endregion

	//Stoutland Pokemon Class
	#region Stoutland
	public class Stoutland : Pokemon
	{
		#region Stoutland Builders
		/// <summary>
		/// Stoutland Builder waiting for a Nickname & a Level
		/// </summary>
		public Stoutland(string nickname, int level)
		: base(
				508,
				SpecieStoutland.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stoutland Builder only waiting for a Level
		/// </summary>
		public Stoutland(int level)
		: base(
				508,
				SpecieStoutland.Instance, // Pokemon Specie
				"Stoutland", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stoutland Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Stoutland() : base(
			508,
			SpecieStoutland.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}