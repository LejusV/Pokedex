using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pangoro Specie to store common natural stats of all Pangoros
	#region SpeciePangoro
	public class SpeciePangoro : PokemonSpecie
	{
#nullable enable
		private static SpeciePangoro? _instance = null;
#nullable restore
        public static SpeciePangoro Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePangoro();
                }
                return _instance;
            }
        }

		#region SpeciePangoro Builder
		public SpeciePangoro() : base(
			"Pangoro",
			95, // HPs
			124, 78, // Attack & Defense
			69, 71, // Special Attack & Defense
			58			
		) {}
		#endregion
	}
	#endregion

	//Pangoro Pokemon Class
	#region Pangoro
	public class Pangoro : Pokemon
	{
		#region Pangoro Builders
		/// <summary>
		/// Pangoro Builder waiting for a Nickname & a Level
		/// </summary>
		public Pangoro(string nickname, int level)
		: base(
				675,
				SpeciePangoro.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pangoro Builder only waiting for a Level
		/// </summary>
		public Pangoro(int level)
		: base(
				675,
				SpeciePangoro.Instance, // Pokemon Specie
				"Pangoro", level,
				Fighting.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pangoro Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Pangoro() : base(
			675,
			SpeciePangoro.Instance, // Pokemon Specie
			Fighting.Instance, Dark.Instance			
		) {}
		#endregion
	}
	#endregion
}