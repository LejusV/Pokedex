using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Klinklang Specie to store common natural stats of all Klinklangs
	#region SpecieKlinklang
	public class SpecieKlinklang : PokemonSpecie
	{
#nullable enable
		private static SpecieKlinklang? _instance = null;
#nullable restore
        public static SpecieKlinklang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKlinklang();
                }
                return _instance;
            }
        }

		#region SpecieKlinklang Builder
		public SpecieKlinklang() : base(
			"Klinklang",
			0.6,
			81.0,
			60, // HPs
			100, 115, // Attack & Defense
			70, 85, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Klinklang Pokemon Class
	#region Klinklang
	public class Klinklang : Pokemon
	{
		#region Klinklang Builders
		/// <summary>
		/// Klinklang Builder waiting for a Nickname & a Level
		/// </summary>
		public Klinklang(string nickname, int level)
		: base(
				601,
				SpecieKlinklang.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klinklang Builder only waiting for a Level
		/// </summary>
		public Klinklang(int level)
		: base(
				601,
				SpecieKlinklang.Instance, // Pokemon Specie
				"Klinklang", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klinklang Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Klinklang() : base(
			601,
			SpecieKlinklang.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}