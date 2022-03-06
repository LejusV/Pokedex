using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Walrein Specie to store common natural stats of all Walreins
	#region SpecieWalrein
	public class SpecieWalrein : PokemonSpecie
	{
#nullable enable
		private static SpecieWalrein? _instance = null;
#nullable restore
        public static SpecieWalrein Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWalrein();
                }
                return _instance;
            }
        }

		#region SpecieWalrein Builder
		public SpecieWalrein() : base(
			"Walrein",
			1.4,
			150.6,
			110, // HPs
			80, 90, // Attack & Defense
			95, 90, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Walrein Pokemon Class
	#region Walrein
	public class Walrein : Pokemon
	{
		#region Walrein Builders
		/// <summary>
		/// Walrein Builder waiting for a Nickname & a Level
		/// </summary>
		public Walrein(string nickname, int level)
		: base(
				365,
				SpecieWalrein.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Walrein Builder only waiting for a Level
		/// </summary>
		public Walrein(int level)
		: base(
				365,
				SpecieWalrein.Instance, // Pokemon Specie
				"Walrein", level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Walrein Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Walrein() : base(
			365,
			SpecieWalrein.Instance, // Pokemon Specie
			Ice.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}