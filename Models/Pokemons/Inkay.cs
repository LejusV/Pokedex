using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Inkay Specie to store common natural stats of all Inkays
	#region SpecieInkay
	public class SpecieInkay : PokemonSpecie
	{
#nullable enable
		private static SpecieInkay? _instance = null;
#nullable restore
        public static SpecieInkay Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieInkay();
                }
                return _instance;
            }
        }

		#region SpecieInkay Builder
		public SpecieInkay() : base(
			"Inkay",
			53, // HPs
			54, 53, // Attack & Defense
			37, 46, // Special Attack & Defense
			45		
		)
		{
			this._height = 4;
			this._weight = 35;
		}
		#endregion
	}
	#endregion

	//Inkay Pokemon Class
	#region Inkay
	public class Inkay : Pokemon
	{
		#region Inkay Builders
		/// <summary>
		/// Inkay Builder waiting for a Nickname & a Level
		/// </summary>
		public Inkay(string nickname, int level)
		: base(
				686,
				SpecieInkay.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inkay Builder only waiting for a Level
		/// </summary>
		public Inkay(int level)
		: base(
				686,
				SpecieInkay.Instance, // Pokemon Specie
				"Inkay", level,
				Dark.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inkay Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Inkay() : base(
			686,
			SpecieInkay.Instance, // Pokemon Specie
			Dark.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}