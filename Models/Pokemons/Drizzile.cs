using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drizzile Specie to store common natural stats of all Drizziles
	#region SpecieDrizzile
	public class SpecieDrizzile : PokemonSpecie
	{
#nullable enable
		private static SpecieDrizzile? _instance = null;
#nullable restore
        public static SpecieDrizzile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrizzile();
                }
                return _instance;
            }
        }

		#region SpecieDrizzile Builder
		public SpecieDrizzile() : base(
			"Drizzile",
			65, // HPs
			60, 55, // Attack & Defense
			95, 55, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Drizzile Pokemon Class
	#region Drizzile
	public class Drizzile : Pokemon
	{
		#region Drizzile Builders
		/// <summary>
		/// Drizzile Builder waiting for a Nickname & a Level
		/// </summary>
		public Drizzile(string nickname, int level)
		: base(
				817,
				SpecieDrizzile.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drizzile Builder only waiting for a Level
		/// </summary>
		public Drizzile(int level)
		: base(
				817,
				SpecieDrizzile.Instance, // Pokemon Specie
				"Drizzile", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drizzile Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Drizzile() : base(
			817,
			SpecieDrizzile.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}