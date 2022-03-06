using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Stakataka Specie to store common natural stats of all Stakatakas
	#region SpecieStakataka
	public class SpecieStakataka : PokemonSpecie
	{
#nullable enable
		private static SpecieStakataka? _instance = null;
#nullable restore
        public static SpecieStakataka Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStakataka();
                }
                return _instance;
            }
        }

		#region SpecieStakataka Builder
		public SpecieStakataka() : base(
			"Stakataka",
			61, // HPs
			131, 211, // Attack & Defense
			53, 101, // Special Attack & Defense
			13		
		)
		{
			this._height = 55;
			this._weight = 8200;
		}
		#endregion
	}
	#endregion

	//Stakataka Pokemon Class
	#region Stakataka
	public class Stakataka : Pokemon
	{
		#region Stakataka Builders
		/// <summary>
		/// Stakataka Builder waiting for a Nickname & a Level
		/// </summary>
		public Stakataka(string nickname, int level)
		: base(
				805,
				SpecieStakataka.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stakataka Builder only waiting for a Level
		/// </summary>
		public Stakataka(int level)
		: base(
				805,
				SpecieStakataka.Instance, // Pokemon Specie
				"Stakataka", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stakataka Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Stakataka() : base(
			805,
			SpecieStakataka.Instance, // Pokemon Specie
			Rock.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}