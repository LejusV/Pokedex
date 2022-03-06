using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Whirlipede Specie to store common natural stats of all Whirlipedes
	#region SpecieWhirlipede
	public class SpecieWhirlipede : PokemonSpecie
	{
#nullable enable
		private static SpecieWhirlipede? _instance = null;
#nullable restore
        public static SpecieWhirlipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWhirlipede();
                }
                return _instance;
            }
        }

		#region SpecieWhirlipede Builder
		public SpecieWhirlipede() : base(
			"Whirlipede",
			40, // HPs
			55, 99, // Attack & Defense
			40, 79, // Special Attack & Defense
			47		
		)
		{
			this._height = 12;
			this._weight = 585;
		}
		#endregion
	}
	#endregion

	//Whirlipede Pokemon Class
	#region Whirlipede
	public class Whirlipede : Pokemon
	{
		#region Whirlipede Builders
		/// <summary>
		/// Whirlipede Builder waiting for a Nickname & a Level
		/// </summary>
		public Whirlipede(string nickname, int level)
		: base(
				544,
				SpecieWhirlipede.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whirlipede Builder only waiting for a Level
		/// </summary>
		public Whirlipede(int level)
		: base(
				544,
				SpecieWhirlipede.Instance, // Pokemon Specie
				"Whirlipede", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whirlipede Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Whirlipede() : base(
			544,
			SpecieWhirlipede.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}