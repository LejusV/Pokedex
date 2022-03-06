using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Scrafty Specie to store common natural stats of all Scraftys
	#region SpecieScrafty
	public class SpecieScrafty : PokemonSpecie
	{
#nullable enable
		private static SpecieScrafty? _instance = null;
#nullable restore
        public static SpecieScrafty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScrafty();
                }
                return _instance;
            }
        }

		#region SpecieScrafty Builder
		public SpecieScrafty() : base(
			"Scrafty",
			65, // HPs
			90, 115, // Attack & Defense
			45, 115, // Special Attack & Defense
			58		
		)
		{
			this._height = 11;
			this._weight = 300;
		}
		#endregion
	}
	#endregion

	//Scrafty Pokemon Class
	#region Scrafty
	public class Scrafty : Pokemon
	{
		#region Scrafty Builders
		/// <summary>
		/// Scrafty Builder waiting for a Nickname & a Level
		/// </summary>
		public Scrafty(string nickname, int level)
		: base(
				560,
				SpecieScrafty.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scrafty Builder only waiting for a Level
		/// </summary>
		public Scrafty(int level)
		: base(
				560,
				SpecieScrafty.Instance, // Pokemon Specie
				"Scrafty", level,
				Dark.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scrafty Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Scrafty() : base(
			560,
			SpecieScrafty.Instance, // Pokemon Specie
			Dark.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}