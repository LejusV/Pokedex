using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Axew Specie to store common natural stats of all Axews
	#region SpecieAxew
	public class SpecieAxew : PokemonSpecie
	{
#nullable enable
		private static SpecieAxew? _instance = null;
#nullable restore
        public static SpecieAxew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAxew();
                }
                return _instance;
            }
        }

		#region SpecieAxew Builder
		public SpecieAxew() : base(
			"Axew",
			46, // HPs
			87, 60, // Attack & Defense
			30, 40, // Special Attack & Defense
			57		
		)
		{
			this._height = 6;
			this._weight = 180;
		}
		#endregion
	}
	#endregion

	//Axew Pokemon Class
	#region Axew
	public class Axew : Pokemon
	{
		#region Axew Builders
		/// <summary>
		/// Axew Builder waiting for a Nickname & a Level
		/// </summary>
		public Axew(string nickname, int level)
		: base(
				610,
				SpecieAxew.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Axew Builder only waiting for a Level
		/// </summary>
		public Axew(int level)
		: base(
				610,
				SpecieAxew.Instance, // Pokemon Specie
				"Axew", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Axew Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Axew() : base(
			610,
			SpecieAxew.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}