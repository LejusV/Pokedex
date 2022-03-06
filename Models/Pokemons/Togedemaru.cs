using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Togedemaru Specie to store common natural stats of all Togedemarus
	#region SpecieTogedemaru
	public class SpecieTogedemaru : PokemonSpecie
	{
#nullable enable
		private static SpecieTogedemaru? _instance = null;
#nullable restore
        public static SpecieTogedemaru Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTogedemaru();
                }
                return _instance;
            }
        }

		#region SpecieTogedemaru Builder
		public SpecieTogedemaru() : base(
			"Togedemaru",
			65, // HPs
			98, 63, // Attack & Defense
			40, 73, // Special Attack & Defense
			96		
		)
		{
			this._height = 3;
			this._weight = 33;
		}
		#endregion
	}
	#endregion

	//Togedemaru Pokemon Class
	#region Togedemaru
	public class Togedemaru : Pokemon
	{
		#region Togedemaru Builders
		/// <summary>
		/// Togedemaru Builder waiting for a Nickname & a Level
		/// </summary>
		public Togedemaru(string nickname, int level)
		: base(
				777,
				SpecieTogedemaru.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togedemaru Builder only waiting for a Level
		/// </summary>
		public Togedemaru(int level)
		: base(
				777,
				SpecieTogedemaru.Instance, // Pokemon Specie
				"Togedemaru", level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togedemaru Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Togedemaru() : base(
			777,
			SpecieTogedemaru.Instance, // Pokemon Specie
			Electric.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}