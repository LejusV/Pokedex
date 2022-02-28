using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Froakie Specie to store common natural stats of all Froakies
	#region SpecieFroakie
	public class SpecieFroakie : PokemonSpecie
	{
#nullable enable
		private static SpecieFroakie? _instance = null;
#nullable restore
        public static SpecieFroakie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFroakie();
                }
                return _instance;
            }
        }

		#region SpecieFroakie Builder
		public SpecieFroakie() : base(
			"Froakie",
			41, // HPs
			56, 40, // Attack & Defense
			62, 44, // Special Attack & Defense
			71			
		) {}
		#endregion
	}
	#endregion

	//Froakie Pokemon Class
	#region Froakie
	public class Froakie : Pokemon
	{
		#region Froakie Builders
		/// <summary>
		/// Froakie Builder waiting for a Nickname & a Level
		/// </summary>
		public Froakie(string nickname, int level)
		: base(
				656,
				SpecieFroakie.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froakie Builder only waiting for a Level
		/// </summary>
		public Froakie(int level)
		: base(
				656,
				SpecieFroakie.Instance, // Pokemon Specie
				"Froakie", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froakie Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Froakie() : base(
			656,
			SpecieFroakie.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}