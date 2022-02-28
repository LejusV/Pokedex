using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Makuhita Specie to store common natural stats of all Makuhitas
	#region SpecieMakuhita
	public class SpecieMakuhita : PokemonSpecie
	{
#nullable enable
		private static SpecieMakuhita? _instance = null;
#nullable restore
        public static SpecieMakuhita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMakuhita();
                }
                return _instance;
            }
        }

		#region SpecieMakuhita Builder
		public SpecieMakuhita() : base(
			"Makuhita",
			72, // HPs
			60, 30, // Attack & Defense
			20, 30, // Special Attack & Defense
			25			
		) {}
		#endregion
	}
	#endregion

	//Makuhita Pokemon Class
	#region Makuhita
	public class Makuhita : Pokemon
	{
		#region Makuhita Builders
		/// <summary>
		/// Makuhita Builder waiting for a Nickname & a Level
		/// </summary>
		public Makuhita(string nickname, int level)
		: base(
				296,
				SpecieMakuhita.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Makuhita Builder only waiting for a Level
		/// </summary>
		public Makuhita(int level)
		: base(
				296,
				SpecieMakuhita.Instance, // Pokemon Specie
				"Makuhita", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Makuhita Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Makuhita() : base(
			296,
			SpecieMakuhita.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}