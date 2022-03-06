using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Weezing Specie to store common natural stats of all Weezings
	#region SpecieWeezing
	public class SpecieWeezing : PokemonSpecie
	{
#nullable enable
		private static SpecieWeezing? _instance = null;
#nullable restore
        public static SpecieWeezing Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWeezing();
                }
                return _instance;
            }
        }

		#region SpecieWeezing Builder
		public SpecieWeezing() : base(
			"Weezing",
			65, // HPs
			90, 120, // Attack & Defense
			85, 70, // Special Attack & Defense
			60		
		)
		{
			this._height = 12;
			this._weight = 95;
		}
		#endregion
	}
	#endregion

	//Weezing Pokemon Class
	#region Weezing
	public class Weezing : Pokemon
	{
		#region Weezing Builders
		/// <summary>
		/// Weezing Builder waiting for a Nickname & a Level
		/// </summary>
		public Weezing(string nickname, int level)
		: base(
				110,
				SpecieWeezing.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weezing Builder only waiting for a Level
		/// </summary>
		public Weezing(int level)
		: base(
				110,
				SpecieWeezing.Instance, // Pokemon Specie
				"Weezing", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weezing Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Weezing() : base(
			110,
			SpecieWeezing.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}