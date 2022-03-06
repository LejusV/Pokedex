using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kricketot Specie to store common natural stats of all Kricketots
	#region SpecieKricketot
	public class SpecieKricketot : PokemonSpecie
	{
#nullable enable
		private static SpecieKricketot? _instance = null;
#nullable restore
        public static SpecieKricketot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKricketot();
                }
                return _instance;
            }
        }

		#region SpecieKricketot Builder
		public SpecieKricketot() : base(
			"Kricketot",
			0.3,
			2.2,
			37, // HPs
			25, 41, // Attack & Defense
			25, 41, // Special Attack & Defense
			25		
		)
		{}
		#endregion
	}
	#endregion

	//Kricketot Pokemon Class
	#region Kricketot
	public class Kricketot : Pokemon
	{
		#region Kricketot Builders
		/// <summary>
		/// Kricketot Builder waiting for a Nickname & a Level
		/// </summary>
		public Kricketot(string nickname, int level)
		: base(
				401,
				SpecieKricketot.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketot Builder only waiting for a Level
		/// </summary>
		public Kricketot(int level)
		: base(
				401,
				SpecieKricketot.Instance, // Pokemon Specie
				"Kricketot", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketot Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kricketot() : base(
			401,
			SpecieKricketot.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}