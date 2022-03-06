using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Purrloin Specie to store common natural stats of all Purrloins
	#region SpeciePurrloin
	public class SpeciePurrloin : PokemonSpecie
	{
#nullable enable
		private static SpeciePurrloin? _instance = null;
#nullable restore
        public static SpeciePurrloin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePurrloin();
                }
                return _instance;
            }
        }

		#region SpeciePurrloin Builder
		public SpeciePurrloin() : base(
			"Purrloin",
			0.4,
			10.1,
			41, // HPs
			50, 37, // Attack & Defense
			50, 37, // Special Attack & Defense
			66		
		)
		{}
		#endregion
	}
	#endregion

	//Purrloin Pokemon Class
	#region Purrloin
	public class Purrloin : Pokemon
	{
		#region Purrloin Builders
		/// <summary>
		/// Purrloin Builder waiting for a Nickname & a Level
		/// </summary>
		public Purrloin(string nickname, int level)
		: base(
				509,
				SpeciePurrloin.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purrloin Builder only waiting for a Level
		/// </summary>
		public Purrloin(int level)
		: base(
				509,
				SpeciePurrloin.Instance, // Pokemon Specie
				"Purrloin", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purrloin Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Purrloin() : base(
			509,
			SpeciePurrloin.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}