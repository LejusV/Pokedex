using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cofagrigus Specie to store common natural stats of all Cofagriguss
	#region SpecieCofagrigus
	public class SpecieCofagrigus : PokemonSpecie
	{
#nullable enable
		private static SpecieCofagrigus? _instance = null;
#nullable restore
        public static SpecieCofagrigus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCofagrigus();
                }
                return _instance;
            }
        }

		#region SpecieCofagrigus Builder
		public SpecieCofagrigus() : base(
			"Cofagrigus",
			58, // HPs
			50, 145, // Attack & Defense
			95, 105, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Cofagrigus Pokemon Class
	#region Cofagrigus
	public class Cofagrigus : Pokemon
	{
		#region Cofagrigus Builders
		/// <summary>
		/// Cofagrigus Builder waiting for a Nickname & a Level
		/// </summary>
		public Cofagrigus(string nickname, int level)
		: base(
				563,
				SpecieCofagrigus.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cofagrigus Builder only waiting for a Level
		/// </summary>
		public Cofagrigus(int level)
		: base(
				563,
				SpecieCofagrigus.Instance, // Pokemon Specie
				"Cofagrigus", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cofagrigus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Cofagrigus() : base(
			563,
			SpecieCofagrigus.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}