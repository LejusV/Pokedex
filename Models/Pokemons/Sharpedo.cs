using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sharpedo Specie to store common natural stats of all Sharpedos
	#region SpecieSharpedo
	public class SpecieSharpedo : PokemonSpecie
	{
#nullable enable
		private static SpecieSharpedo? _instance = null;
#nullable restore
        public static SpecieSharpedo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSharpedo();
                }
                return _instance;
            }
        }

		#region SpecieSharpedo Builder
		public SpecieSharpedo() : base(
			"Sharpedo",
			70, // HPs
			120, 40, // Attack & Defense
			95, 40, // Special Attack & Defense
			95		
		)
		{
			this._height = 18;
			this._weight = 888;
		}
		#endregion
	}
	#endregion

	//Sharpedo Pokemon Class
	#region Sharpedo
	public class Sharpedo : Pokemon
	{
		#region Sharpedo Builders
		/// <summary>
		/// Sharpedo Builder waiting for a Nickname & a Level
		/// </summary>
		public Sharpedo(string nickname, int level)
		: base(
				319,
				SpecieSharpedo.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sharpedo Builder only waiting for a Level
		/// </summary>
		public Sharpedo(int level)
		: base(
				319,
				SpecieSharpedo.Instance, // Pokemon Specie
				"Sharpedo", level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sharpedo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sharpedo() : base(
			319,
			SpecieSharpedo.Instance, // Pokemon Specie
			Water.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}