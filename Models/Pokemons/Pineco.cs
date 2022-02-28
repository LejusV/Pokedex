using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pineco Specie to store common natural stats of all Pinecos
	#region SpeciePineco
	public class SpeciePineco : PokemonSpecie
	{
#nullable enable
		private static SpeciePineco? _instance = null;
#nullable restore
        public static SpeciePineco Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePineco();
                }
                return _instance;
            }
        }

		#region SpeciePineco Builder
		public SpeciePineco() : base(
			"Pineco",
			50, // HPs
			65, 90, // Attack & Defense
			35, 35, // Special Attack & Defense
			15			
		) {}
		#endregion
	}
	#endregion

	//Pineco Pokemon Class
	#region Pineco
	public class Pineco : Pokemon
	{
		#region Pineco Builders
		/// <summary>
		/// Pineco Builder waiting for a Nickname & a Level
		/// </summary>
		public Pineco(string nickname, int level)
		: base(
				204,
				SpeciePineco.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pineco Builder only waiting for a Level
		/// </summary>
		public Pineco(int level)
		: base(
				204,
				SpeciePineco.Instance, // Pokemon Specie
				"Pineco", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pineco Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Pineco() : base(
			204,
			SpeciePineco.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}