using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Goodra Specie to store common natural stats of all Goodras
	#region SpecieGoodra
	public class SpecieGoodra : PokemonSpecie
	{
#nullable enable
		private static SpecieGoodra? _instance = null;
#nullable restore
        public static SpecieGoodra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGoodra();
                }
                return _instance;
            }
        }

		#region SpecieGoodra Builder
		public SpecieGoodra() : base(
			"Goodra",
			90, // HPs
			100, 70, // Attack & Defense
			110, 150, // Special Attack & Defense
			80		
		)
		{
			this._height = 20;
			this._weight = 1505;
		}
		#endregion
	}
	#endregion

	//Goodra Pokemon Class
	#region Goodra
	public class Goodra : Pokemon
	{
		#region Goodra Builders
		/// <summary>
		/// Goodra Builder waiting for a Nickname & a Level
		/// </summary>
		public Goodra(string nickname, int level)
		: base(
				706,
				SpecieGoodra.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goodra Builder only waiting for a Level
		/// </summary>
		public Goodra(int level)
		: base(
				706,
				SpecieGoodra.Instance, // Pokemon Specie
				"Goodra", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goodra Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Goodra() : base(
			706,
			SpecieGoodra.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}