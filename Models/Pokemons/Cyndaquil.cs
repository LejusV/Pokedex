using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cyndaquil Specie to store common natural stats of all Cyndaquils
	#region SpecieCyndaquil
	public class SpecieCyndaquil : PokemonSpecie
	{
#nullable enable
		private static SpecieCyndaquil? _instance = null;
#nullable restore
        public static SpecieCyndaquil Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCyndaquil();
                }
                return _instance;
            }
        }

		#region SpecieCyndaquil Builder
		public SpecieCyndaquil() : base(
			"Cyndaquil",
			39, // HPs
			52, 43, // Attack & Defense
			60, 50, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Cyndaquil Pokemon Class
	#region Cyndaquil
	public class Cyndaquil : Pokemon
	{
		#region Cyndaquil Builders
		/// <summary>
		/// Cyndaquil Builder waiting for a Nickname & a Level
		/// </summary>
		public Cyndaquil(string nickname, int level)
		: base(
				155,
				SpecieCyndaquil.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cyndaquil Builder only waiting for a Level
		/// </summary>
		public Cyndaquil(int level)
		: base(
				155,
				SpecieCyndaquil.Instance, // Pokemon Specie
				"Cyndaquil", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cyndaquil Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Cyndaquil() : base(
			155,
			SpecieCyndaquil.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}