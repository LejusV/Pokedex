using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Vanilluxe Specie to store common natural stats of all Vanilluxes
	#region SpecieVanilluxe
	public class SpecieVanilluxe : PokemonSpecie
	{
#nullable enable
		private static SpecieVanilluxe? _instance = null;
#nullable restore
        public static SpecieVanilluxe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVanilluxe();
                }
                return _instance;
            }
        }

		#region SpecieVanilluxe Builder
		public SpecieVanilluxe() : base(
			"Vanilluxe",
			1.3,
			57.5,
			71, // HPs
			95, 85, // Attack & Defense
			110, 95, // Special Attack & Defense
			79		
		)
		{}
		#endregion
	}
	#endregion

	//Vanilluxe Pokemon Class
	#region Vanilluxe
	public class Vanilluxe : Pokemon
	{
		#region Vanilluxe Builders
		/// <summary>
		/// Vanilluxe Builder waiting for a Nickname & a Level
		/// </summary>
		public Vanilluxe(string nickname, int level)
		: base(
				584,
				SpecieVanilluxe.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanilluxe Builder only waiting for a Level
		/// </summary>
		public Vanilluxe(int level)
		: base(
				584,
				SpecieVanilluxe.Instance, // Pokemon Specie
				"Vanilluxe", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanilluxe Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Vanilluxe() : base(
			584,
			SpecieVanilluxe.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}