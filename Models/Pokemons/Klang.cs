using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Klang Specie to store common natural stats of all Klangs
	#region SpecieKlang
	public class SpecieKlang : PokemonSpecie
	{
#nullable enable
		private static SpecieKlang? _instance = null;
#nullable restore
        public static SpecieKlang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKlang();
                }
                return _instance;
            }
        }

		#region SpecieKlang Builder
		public SpecieKlang() : base(
			"Klang",
			60, // HPs
			80, 95, // Attack & Defense
			70, 85, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Klang Pokemon Class
	#region Klang
	public class Klang : Pokemon
	{
		#region Klang Builders
		/// <summary>
		/// Klang Builder waiting for a Nickname & a Level
		/// </summary>
		public Klang(string nickname, int level)
		: base(
				600,
				SpecieKlang.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klang Builder only waiting for a Level
		/// </summary>
		public Klang(int level)
		: base(
				600,
				SpecieKlang.Instance, // Pokemon Specie
				"Klang", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klang Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Klang() : base(
			600,
			SpecieKlang.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
		#endregion
	}
	#endregion
}