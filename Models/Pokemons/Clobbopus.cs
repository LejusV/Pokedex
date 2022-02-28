using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Clobbopus Specie to store common natural stats of all Clobbopuss
	#region SpecieClobbopus
	public class SpecieClobbopus : PokemonSpecie
	{
#nullable enable
		private static SpecieClobbopus? _instance = null;
#nullable restore
        public static SpecieClobbopus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClobbopus();
                }
                return _instance;
            }
        }

		#region SpecieClobbopus Builder
		public SpecieClobbopus() : base(
			"Clobbopus",
			50, // HPs
			68, 60, // Attack & Defense
			50, 50, // Special Attack & Defense
			32			
		) {}
		#endregion
	}
	#endregion

	//Clobbopus Pokemon Class
	#region Clobbopus
	public class Clobbopus : Pokemon
	{
		#region Clobbopus Builders
		/// <summary>
		/// Clobbopus Builder waiting for a Nickname & a Level
		/// </summary>
		public Clobbopus(string nickname, int level)
		: base(
				852,
				SpecieClobbopus.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clobbopus Builder only waiting for a Level
		/// </summary>
		public Clobbopus(int level)
		: base(
				852,
				SpecieClobbopus.Instance, // Pokemon Specie
				"Clobbopus", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clobbopus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Clobbopus() : base(
			852,
			SpecieClobbopus.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}