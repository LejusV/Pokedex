using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Maractus Specie to store common natural stats of all Maractuss
	#region SpecieMaractus
	public class SpecieMaractus : PokemonSpecie
	{
#nullable enable
		private static SpecieMaractus? _instance = null;
#nullable restore
        public static SpecieMaractus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMaractus();
                }
                return _instance;
            }
        }

		#region SpecieMaractus Builder
		public SpecieMaractus() : base(
			"Maractus",
			75, // HPs
			86, 67, // Attack & Defense
			106, 67, // Special Attack & Defense
			60		
		)
		{
			this._height = 10;
			this._weight = 280;
		}
		#endregion
	}
	#endregion

	//Maractus Pokemon Class
	#region Maractus
	public class Maractus : Pokemon
	{
		#region Maractus Builders
		/// <summary>
		/// Maractus Builder waiting for a Nickname & a Level
		/// </summary>
		public Maractus(string nickname, int level)
		: base(
				556,
				SpecieMaractus.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Maractus Builder only waiting for a Level
		/// </summary>
		public Maractus(int level)
		: base(
				556,
				SpecieMaractus.Instance, // Pokemon Specie
				"Maractus", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Maractus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Maractus() : base(
			556,
			SpecieMaractus.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}