using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Vanillish Specie to store common natural stats of all Vanillishs
	#region SpecieVanillish
	public class SpecieVanillish : PokemonSpecie
	{
#nullable enable
		private static SpecieVanillish? _instance = null;
#nullable restore
        public static SpecieVanillish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVanillish();
                }
                return _instance;
            }
        }

		#region SpecieVanillish Builder
		public SpecieVanillish() : base(
			"Vanillish",
			1.1,
			41.0,
			51, // HPs
			65, 65, // Attack & Defense
			80, 75, // Special Attack & Defense
			59		
		)
		{}
		#endregion
	}
	#endregion

	//Vanillish Pokemon Class
	#region Vanillish
	public class Vanillish : Pokemon
	{
		#region Vanillish Builders
		/// <summary>
		/// Vanillish Builder waiting for a Nickname & a Level
		/// </summary>
		public Vanillish(string nickname, int level)
		: base(
				583,
				SpecieVanillish.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillish Builder only waiting for a Level
		/// </summary>
		public Vanillish(int level)
		: base(
				583,
				SpecieVanillish.Instance, // Pokemon Specie
				"Vanillish", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillish Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Vanillish() : base(
			583,
			SpecieVanillish.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}