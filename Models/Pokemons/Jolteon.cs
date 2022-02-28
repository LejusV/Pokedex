using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Jolteon Specie to store common natural stats of all Jolteons
	#region SpecieJolteon
	public class SpecieJolteon : PokemonSpecie
	{
#nullable enable
		private static SpecieJolteon? _instance = null;
#nullable restore
        public static SpecieJolteon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJolteon();
                }
                return _instance;
            }
        }

		#region SpecieJolteon Builder
		public SpecieJolteon() : base(
			"Jolteon",
			65, // HPs
			65, 60, // Attack & Defense
			110, 95, // Special Attack & Defense
			130			
		) {}
		#endregion
	}
	#endregion

	//Jolteon Pokemon Class
	#region Jolteon
	public class Jolteon : Pokemon
	{
		#region Jolteon Builders
		/// <summary>
		/// Jolteon Builder waiting for a Nickname & a Level
		/// </summary>
		public Jolteon(string nickname, int level)
		: base(
				135,
				SpecieJolteon.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jolteon Builder only waiting for a Level
		/// </summary>
		public Jolteon(int level)
		: base(
				135,
				SpecieJolteon.Instance, // Pokemon Specie
				"Jolteon", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jolteon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Jolteon() : base(
			135,
			SpecieJolteon.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}