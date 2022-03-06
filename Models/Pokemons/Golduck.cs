using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Golduck Specie to store common natural stats of all Golducks
	#region SpecieGolduck
	public class SpecieGolduck : PokemonSpecie
	{
#nullable enable
		private static SpecieGolduck? _instance = null;
#nullable restore
        public static SpecieGolduck Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolduck();
                }
                return _instance;
            }
        }

		#region SpecieGolduck Builder
		public SpecieGolduck() : base(
			"Golduck",
			1.7,
			76.6,
			80, // HPs
			82, 78, // Attack & Defense
			95, 80, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Golduck Pokemon Class
	#region Golduck
	public class Golduck : Pokemon
	{
		#region Golduck Builders
		/// <summary>
		/// Golduck Builder waiting for a Nickname & a Level
		/// </summary>
		public Golduck(string nickname, int level)
		: base(
				55,
				SpecieGolduck.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golduck Builder only waiting for a Level
		/// </summary>
		public Golduck(int level)
		: base(
				55,
				SpecieGolduck.Instance, // Pokemon Specie
				"Golduck", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golduck Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Golduck() : base(
			55,
			SpecieGolduck.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}