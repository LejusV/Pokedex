using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Oranguru Specie to store common natural stats of all Orangurus
	#region SpecieOranguru
	public class SpecieOranguru : PokemonSpecie
	{
#nullable enable
		private static SpecieOranguru? _instance = null;
#nullable restore
        public static SpecieOranguru Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOranguru();
                }
                return _instance;
            }
        }

		#region SpecieOranguru Builder
		public SpecieOranguru() : base(
			"Oranguru",
			90, // HPs
			60, 80, // Attack & Defense
			90, 110, // Special Attack & Defense
			60		
		)
		{
			this._height = 15;
			this._weight = 760;
		}
		#endregion
	}
	#endregion

	//Oranguru Pokemon Class
	#region Oranguru
	public class Oranguru : Pokemon
	{
		#region Oranguru Builders
		/// <summary>
		/// Oranguru Builder waiting for a Nickname & a Level
		/// </summary>
		public Oranguru(string nickname, int level)
		: base(
				765,
				SpecieOranguru.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oranguru Builder only waiting for a Level
		/// </summary>
		public Oranguru(int level)
		: base(
				765,
				SpecieOranguru.Instance, // Pokemon Specie
				"Oranguru", level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oranguru Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Oranguru() : base(
			765,
			SpecieOranguru.Instance, // Pokemon Specie
			Normal.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}