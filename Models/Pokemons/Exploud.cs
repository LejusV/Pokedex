using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Exploud Specie to store common natural stats of all Explouds
	#region SpecieExploud
	public class SpecieExploud : PokemonSpecie
	{
#nullable enable
		private static SpecieExploud? _instance = null;
#nullable restore
        public static SpecieExploud Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieExploud();
                }
                return _instance;
            }
        }

		#region SpecieExploud Builder
		public SpecieExploud() : base(
			"Exploud",
			104, // HPs
			91, 63, // Attack & Defense
			91, 73, // Special Attack & Defense
			68		
		)
		{
			this._height = 15;
			this._weight = 840;
		}
		#endregion
	}
	#endregion

	//Exploud Pokemon Class
	#region Exploud
	public class Exploud : Pokemon
	{
		#region Exploud Builders
		/// <summary>
		/// Exploud Builder waiting for a Nickname & a Level
		/// </summary>
		public Exploud(string nickname, int level)
		: base(
				295,
				SpecieExploud.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exploud Builder only waiting for a Level
		/// </summary>
		public Exploud(int level)
		: base(
				295,
				SpecieExploud.Instance, // Pokemon Specie
				"Exploud", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exploud Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Exploud() : base(
			295,
			SpecieExploud.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}