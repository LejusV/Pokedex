using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sawk Specie to store common natural stats of all Sawks
	#region SpecieSawk
	public class SpecieSawk : PokemonSpecie
	{
#nullable enable
		private static SpecieSawk? _instance = null;
#nullable restore
        public static SpecieSawk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSawk();
                }
                return _instance;
            }
        }

		#region SpecieSawk Builder
		public SpecieSawk() : base(
			"Sawk",
			75, // HPs
			125, 75, // Attack & Defense
			30, 75, // Special Attack & Defense
			85		
		)
		{
			this._height = 14;
			this._weight = 510;
		}
		#endregion
	}
	#endregion

	//Sawk Pokemon Class
	#region Sawk
	public class Sawk : Pokemon
	{
		#region Sawk Builders
		/// <summary>
		/// Sawk Builder waiting for a Nickname & a Level
		/// </summary>
		public Sawk(string nickname, int level)
		: base(
				539,
				SpecieSawk.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawk Builder only waiting for a Level
		/// </summary>
		public Sawk(int level)
		: base(
				539,
				SpecieSawk.Instance, // Pokemon Specie
				"Sawk", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawk Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sawk() : base(
			539,
			SpecieSawk.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}