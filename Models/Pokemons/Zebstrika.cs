using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Zebstrika Specie to store common natural stats of all Zebstrikas
	#region SpecieZebstrika
	public class SpecieZebstrika : PokemonSpecie
	{
#nullable enable
		private static SpecieZebstrika? _instance = null;
#nullable restore
        public static SpecieZebstrika Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZebstrika();
                }
                return _instance;
            }
        }

		#region SpecieZebstrika Builder
		public SpecieZebstrika() : base(
			"Zebstrika",
			75, // HPs
			100, 63, // Attack & Defense
			80, 63, // Special Attack & Defense
			116		
		)
		{
			this._height = 16;
			this._weight = 795;
		}
		#endregion
	}
	#endregion

	//Zebstrika Pokemon Class
	#region Zebstrika
	public class Zebstrika : Pokemon
	{
		#region Zebstrika Builders
		/// <summary>
		/// Zebstrika Builder waiting for a Nickname & a Level
		/// </summary>
		public Zebstrika(string nickname, int level)
		: base(
				523,
				SpecieZebstrika.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zebstrika Builder only waiting for a Level
		/// </summary>
		public Zebstrika(int level)
		: base(
				523,
				SpecieZebstrika.Instance, // Pokemon Specie
				"Zebstrika", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zebstrika Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Zebstrika() : base(
			523,
			SpecieZebstrika.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}