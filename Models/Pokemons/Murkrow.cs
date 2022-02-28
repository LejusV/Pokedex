using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Murkrow Specie to store common natural stats of all Murkrows
	#region SpecieMurkrow
	public class SpecieMurkrow : PokemonSpecie
	{
#nullable enable
		private static SpecieMurkrow? _instance = null;
#nullable restore
        public static SpecieMurkrow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMurkrow();
                }
                return _instance;
            }
        }

		#region SpecieMurkrow Builder
		public SpecieMurkrow() : base(
			"Murkrow",
			60, // HPs
			85, 42, // Attack & Defense
			85, 42, // Special Attack & Defense
			91			
		) {}
		#endregion
	}
	#endregion

	//Murkrow Pokemon Class
	#region Murkrow
	public class Murkrow : Pokemon
	{
		#region Murkrow Builders
		/// <summary>
		/// Murkrow Builder waiting for a Nickname & a Level
		/// </summary>
		public Murkrow(string nickname, int level)
		: base(
				198,
				SpecieMurkrow.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Murkrow Builder only waiting for a Level
		/// </summary>
		public Murkrow(int level)
		: base(
				198,
				SpecieMurkrow.Instance, // Pokemon Specie
				"Murkrow", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Murkrow Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Murkrow() : base(
			198,
			SpecieMurkrow.Instance, // Pokemon Specie
			Dark.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}