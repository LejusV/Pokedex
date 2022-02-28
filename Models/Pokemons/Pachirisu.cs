using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pachirisu Specie to store common natural stats of all Pachirisus
	#region SpeciePachirisu
	public class SpeciePachirisu : PokemonSpecie
	{
#nullable enable
		private static SpeciePachirisu? _instance = null;
#nullable restore
        public static SpeciePachirisu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePachirisu();
                }
                return _instance;
            }
        }

		#region SpeciePachirisu Builder
		public SpeciePachirisu() : base(
			"Pachirisu",
			60, // HPs
			45, 70, // Attack & Defense
			45, 90, // Special Attack & Defense
			95			
		) {}
		#endregion
	}
	#endregion

	//Pachirisu Pokemon Class
	#region Pachirisu
	public class Pachirisu : Pokemon
	{
		#region Pachirisu Builders
		/// <summary>
		/// Pachirisu Builder waiting for a Nickname & a Level
		/// </summary>
		public Pachirisu(string nickname, int level)
		: base(
				417,
				SpeciePachirisu.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pachirisu Builder only waiting for a Level
		/// </summary>
		public Pachirisu(int level)
		: base(
				417,
				SpeciePachirisu.Instance, // Pokemon Specie
				"Pachirisu", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pachirisu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Pachirisu() : base(
			417,
			SpeciePachirisu.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}