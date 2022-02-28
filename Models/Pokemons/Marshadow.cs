using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Marshadow Specie to store common natural stats of all Marshadows
	#region SpecieMarshadow
	public class SpecieMarshadow : PokemonSpecie
	{
#nullable enable
		private static SpecieMarshadow? _instance = null;
#nullable restore
        public static SpecieMarshadow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMarshadow();
                }
                return _instance;
            }
        }

		#region SpecieMarshadow Builder
		public SpecieMarshadow() : base(
			"Marshadow",
			90, // HPs
			125, 80, // Attack & Defense
			90, 90, // Special Attack & Defense
			125			
		) {}
		#endregion
	}
	#endregion

	//Marshadow Pokemon Class
	#region Marshadow
	public class Marshadow : Pokemon
	{
		#region Marshadow Builders
		/// <summary>
		/// Marshadow Builder waiting for a Nickname & a Level
		/// </summary>
		public Marshadow(string nickname, int level)
		: base(
				802,
				SpecieMarshadow.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshadow Builder only waiting for a Level
		/// </summary>
		public Marshadow(int level)
		: base(
				802,
				SpecieMarshadow.Instance, // Pokemon Specie
				"Marshadow", level,
				Fighting.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshadow Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Marshadow() : base(
			802,
			SpecieMarshadow.Instance, // Pokemon Specie
			Fighting.Instance, Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}