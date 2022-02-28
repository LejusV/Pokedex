using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cascoon Specie to store common natural stats of all Cascoons
	#region SpecieCascoon
	public class SpecieCascoon : PokemonSpecie
	{
#nullable enable
		private static SpecieCascoon? _instance = null;
#nullable restore
        public static SpecieCascoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCascoon();
                }
                return _instance;
            }
        }

		#region SpecieCascoon Builder
		public SpecieCascoon() : base(
			"Cascoon",
			50, // HPs
			35, 55, // Attack & Defense
			25, 25, // Special Attack & Defense
			15			
		) {}
		#endregion
	}
	#endregion

	//Cascoon Pokemon Class
	#region Cascoon
	public class Cascoon : Pokemon
	{
		#region Cascoon Builders
		/// <summary>
		/// Cascoon Builder waiting for a Nickname & a Level
		/// </summary>
		public Cascoon(string nickname, int level)
		: base(
				268,
				SpecieCascoon.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cascoon Builder only waiting for a Level
		/// </summary>
		public Cascoon(int level)
		: base(
				268,
				SpecieCascoon.Instance, // Pokemon Specie
				"Cascoon", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cascoon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Cascoon() : base(
			268,
			SpecieCascoon.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}