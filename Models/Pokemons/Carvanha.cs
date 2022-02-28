using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Carvanha Specie to store common natural stats of all Carvanhas
	#region SpecieCarvanha
	public class SpecieCarvanha : PokemonSpecie
	{
#nullable enable
		private static SpecieCarvanha? _instance = null;
#nullable restore
        public static SpecieCarvanha Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCarvanha();
                }
                return _instance;
            }
        }

		#region SpecieCarvanha Builder
		public SpecieCarvanha() : base(
			"Carvanha",
			45, // HPs
			90, 20, // Attack & Defense
			65, 20, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Carvanha Pokemon Class
	#region Carvanha
	public class Carvanha : Pokemon
	{
		#region Carvanha Builders
		/// <summary>
		/// Carvanha Builder waiting for a Nickname & a Level
		/// </summary>
		public Carvanha(string nickname, int level)
		: base(
				318,
				SpecieCarvanha.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carvanha Builder only waiting for a Level
		/// </summary>
		public Carvanha(int level)
		: base(
				318,
				SpecieCarvanha.Instance, // Pokemon Specie
				"Carvanha", level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carvanha Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Carvanha() : base(
			318,
			SpecieCarvanha.Instance, // Pokemon Specie
			Water.Instance, Dark.Instance			
		) {}
		#endregion
	}
	#endregion
}