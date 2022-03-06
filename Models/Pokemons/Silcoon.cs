using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Silcoon Specie to store common natural stats of all Silcoons
	#region SpecieSilcoon
	public class SpecieSilcoon : PokemonSpecie
	{
#nullable enable
		private static SpecieSilcoon? _instance = null;
#nullable restore
        public static SpecieSilcoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSilcoon();
                }
                return _instance;
            }
        }

		#region SpecieSilcoon Builder
		public SpecieSilcoon() : base(
			"Silcoon",
			0.6,
			10.0,
			50, // HPs
			35, 55, // Attack & Defense
			25, 25, // Special Attack & Defense
			15		
		)
		{}
		#endregion
	}
	#endregion

	//Silcoon Pokemon Class
	#region Silcoon
	public class Silcoon : Pokemon
	{
		#region Silcoon Builders
		/// <summary>
		/// Silcoon Builder waiting for a Nickname & a Level
		/// </summary>
		public Silcoon(string nickname, int level)
		: base(
				266,
				SpecieSilcoon.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silcoon Builder only waiting for a Level
		/// </summary>
		public Silcoon(int level)
		: base(
				266,
				SpecieSilcoon.Instance, // Pokemon Specie
				"Silcoon", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silcoon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Silcoon() : base(
			266,
			SpecieSilcoon.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}