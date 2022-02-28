using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Munna Specie to store common natural stats of all Munnas
	#region SpecieMunna
	public class SpecieMunna : PokemonSpecie
	{
#nullable enable
		private static SpecieMunna? _instance = null;
#nullable restore
        public static SpecieMunna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMunna();
                }
                return _instance;
            }
        }

		#region SpecieMunna Builder
		public SpecieMunna() : base(
			"Munna",
			76, // HPs
			25, 45, // Attack & Defense
			67, 55, // Special Attack & Defense
			24			
		) {}
		#endregion
	}
	#endregion

	//Munna Pokemon Class
	#region Munna
	public class Munna : Pokemon
	{
		#region Munna Builders
		/// <summary>
		/// Munna Builder waiting for a Nickname & a Level
		/// </summary>
		public Munna(string nickname, int level)
		: base(
				517,
				SpecieMunna.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munna Builder only waiting for a Level
		/// </summary>
		public Munna(int level)
		: base(
				517,
				SpecieMunna.Instance, // Pokemon Specie
				"Munna", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munna Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Munna() : base(
			517,
			SpecieMunna.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}