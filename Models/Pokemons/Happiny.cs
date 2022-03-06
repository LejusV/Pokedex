using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Happiny Specie to store common natural stats of all Happinys
	#region SpecieHappiny
	public class SpecieHappiny : PokemonSpecie
	{
#nullable enable
		private static SpecieHappiny? _instance = null;
#nullable restore
        public static SpecieHappiny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHappiny();
                }
                return _instance;
            }
        }

		#region SpecieHappiny Builder
		public SpecieHappiny() : base(
			"Happiny",
			0.6,
			24.4,
			100, // HPs
			5, 5, // Attack & Defense
			15, 65, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Happiny Pokemon Class
	#region Happiny
	public class Happiny : Pokemon
	{
		#region Happiny Builders
		/// <summary>
		/// Happiny Builder waiting for a Nickname & a Level
		/// </summary>
		public Happiny(string nickname, int level)
		: base(
				440,
				SpecieHappiny.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Happiny Builder only waiting for a Level
		/// </summary>
		public Happiny(int level)
		: base(
				440,
				SpecieHappiny.Instance, // Pokemon Specie
				"Happiny", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Happiny Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Happiny() : base(
			440,
			SpecieHappiny.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}