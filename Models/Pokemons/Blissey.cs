using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Blissey Specie to store common natural stats of all Blisseys
	#region SpecieBlissey
	public class SpecieBlissey : PokemonSpecie
	{
#nullable enable
		private static SpecieBlissey? _instance = null;
#nullable restore
        public static SpecieBlissey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlissey();
                }
                return _instance;
            }
        }

		#region SpecieBlissey Builder
		public SpecieBlissey() : base(
			"Blissey",
			255, // HPs
			10, 10, // Attack & Defense
			75, 135, // Special Attack & Defense
			55		
		)
		{
			this._height = 15;
			this._weight = 468;
		}
		#endregion
	}
	#endregion

	//Blissey Pokemon Class
	#region Blissey
	public class Blissey : Pokemon
	{
		#region Blissey Builders
		/// <summary>
		/// Blissey Builder waiting for a Nickname & a Level
		/// </summary>
		public Blissey(string nickname, int level)
		: base(
				242,
				SpecieBlissey.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blissey Builder only waiting for a Level
		/// </summary>
		public Blissey(int level)
		: base(
				242,
				SpecieBlissey.Instance, // Pokemon Specie
				"Blissey", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blissey Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Blissey() : base(
			242,
			SpecieBlissey.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}