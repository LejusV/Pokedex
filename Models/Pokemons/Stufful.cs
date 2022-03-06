using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Stufful Specie to store common natural stats of all Stuffuls
	#region SpecieStufful
	public class SpecieStufful : PokemonSpecie
	{
#nullable enable
		private static SpecieStufful? _instance = null;
#nullable restore
        public static SpecieStufful Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStufful();
                }
                return _instance;
            }
        }

		#region SpecieStufful Builder
		public SpecieStufful() : base(
			"Stufful",
			70, // HPs
			75, 50, // Attack & Defense
			45, 50, // Special Attack & Defense
			50		
		)
		{
			this._height = 5;
			this._weight = 68;
		}
		#endregion
	}
	#endregion

	//Stufful Pokemon Class
	#region Stufful
	public class Stufful : Pokemon
	{
		#region Stufful Builders
		/// <summary>
		/// Stufful Builder waiting for a Nickname & a Level
		/// </summary>
		public Stufful(string nickname, int level)
		: base(
				759,
				SpecieStufful.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stufful Builder only waiting for a Level
		/// </summary>
		public Stufful(int level)
		: base(
				759,
				SpecieStufful.Instance, // Pokemon Specie
				"Stufful", level,
				Normal.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stufful Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Stufful() : base(
			759,
			SpecieStufful.Instance, // Pokemon Specie
			Normal.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}