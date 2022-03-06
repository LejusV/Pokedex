using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Metang Specie to store common natural stats of all Metangs
	#region SpecieMetang
	public class SpecieMetang : PokemonSpecie
	{
#nullable enable
		private static SpecieMetang? _instance = null;
#nullable restore
        public static SpecieMetang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMetang();
                }
                return _instance;
            }
        }

		#region SpecieMetang Builder
		public SpecieMetang() : base(
			"Metang",
			60, // HPs
			75, 100, // Attack & Defense
			55, 80, // Special Attack & Defense
			50		
		)
		{
			this._height = 12;
			this._weight = 2025;
		}
		#endregion
	}
	#endregion

	//Metang Pokemon Class
	#region Metang
	public class Metang : Pokemon
	{
		#region Metang Builders
		/// <summary>
		/// Metang Builder waiting for a Nickname & a Level
		/// </summary>
		public Metang(string nickname, int level)
		: base(
				375,
				SpecieMetang.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metang Builder only waiting for a Level
		/// </summary>
		public Metang(int level)
		: base(
				375,
				SpecieMetang.Instance, // Pokemon Specie
				"Metang", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metang Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Metang() : base(
			375,
			SpecieMetang.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}