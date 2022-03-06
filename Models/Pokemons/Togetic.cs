using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Togetic Specie to store common natural stats of all Togetics
	#region SpecieTogetic
	public class SpecieTogetic : PokemonSpecie
	{
#nullable enable
		private static SpecieTogetic? _instance = null;
#nullable restore
        public static SpecieTogetic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTogetic();
                }
                return _instance;
            }
        }

		#region SpecieTogetic Builder
		public SpecieTogetic() : base(
			"Togetic",
			0.6,
			3.2,
			55, // HPs
			40, 85, // Attack & Defense
			80, 105, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Togetic Pokemon Class
	#region Togetic
	public class Togetic : Pokemon
	{
		#region Togetic Builders
		/// <summary>
		/// Togetic Builder waiting for a Nickname & a Level
		/// </summary>
		public Togetic(string nickname, int level)
		: base(
				176,
				SpecieTogetic.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togetic Builder only waiting for a Level
		/// </summary>
		public Togetic(int level)
		: base(
				176,
				SpecieTogetic.Instance, // Pokemon Specie
				"Togetic", level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togetic Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Togetic() : base(
			176,
			SpecieTogetic.Instance, // Pokemon Specie
			Fairy.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}