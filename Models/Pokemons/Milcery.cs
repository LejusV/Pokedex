using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Milcery Specie to store common natural stats of all Milcerys
	#region SpecieMilcery
	public class SpecieMilcery : PokemonSpecie
	{
#nullable enable
		private static SpecieMilcery? _instance = null;
#nullable restore
        public static SpecieMilcery Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMilcery();
                }
                return _instance;
            }
        }

		#region SpecieMilcery Builder
		public SpecieMilcery() : base(
			"Milcery",
			45, // HPs
			40, 40, // Attack & Defense
			50, 61, // Special Attack & Defense
			34			
		) {}
		#endregion
	}
	#endregion

	//Milcery Pokemon Class
	#region Milcery
	public class Milcery : Pokemon
	{
		#region Milcery Builders
		/// <summary>
		/// Milcery Builder waiting for a Nickname & a Level
		/// </summary>
		public Milcery(string nickname, int level)
		: base(
				868,
				SpecieMilcery.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milcery Builder only waiting for a Level
		/// </summary>
		public Milcery(int level)
		: base(
				868,
				SpecieMilcery.Instance, // Pokemon Specie
				"Milcery", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milcery Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Milcery() : base(
			868,
			SpecieMilcery.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}