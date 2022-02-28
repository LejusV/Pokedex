using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Thundurus-Incarnate Specie to store common natural stats of all Thundurus-Incarnates
	#region SpecieThundurus-Incarnate
	public class SpecieThundurusIncarnate : PokemonSpecie
	{
#nullable enable
		private static SpecieThundurusIncarnate? _instance = null;
#nullable restore
        public static SpecieThundurusIncarnate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieThundurusIncarnate();
                }
                return _instance;
            }
        }

		#region SpecieThundurus-Incarnate Builder
		public SpecieThundurusIncarnate() : base(
			"Thundurus-Incarnate",
			79, // HPs
			115, 70, // Attack & Defense
			125, 80, // Special Attack & Defense
			111			
		) {}
		#endregion
	}
	#endregion

	//Thundurus-Incarnate Pokemon Class
	#region Thundurus-Incarnate
	public class ThundurusIncarnate : Pokemon
	{
		#region Thundurus-Incarnate Builders
		/// <summary>
		/// Thundurus-Incarnate Builder waiting for a Nickname & a Level
		/// </summary>
		public ThundurusIncarnate(string nickname, int level)
		: base(
				642,
				SpecieThundurusIncarnate.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thundurus-Incarnate Builder only waiting for a Level
		/// </summary>
		public ThundurusIncarnate(int level)
		: base(
				642,
				SpecieThundurusIncarnate.Instance, // Pokemon Specie
				"Thundurus-Incarnate", level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thundurus-Incarnate Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public ThundurusIncarnate() : base(
			642,
			SpecieThundurusIncarnate.Instance, // Pokemon Specie
			Electric.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}