using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Whismur Specie to store common natural stats of all Whismurs
	#region SpecieWhismur
	public class SpecieWhismur : PokemonSpecie
	{
#nullable enable
		private static SpecieWhismur? _instance = null;
#nullable restore
        public static SpecieWhismur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWhismur();
                }
                return _instance;
            }
        }

		#region SpecieWhismur Builder
		public SpecieWhismur() : base(
			"Whismur",
			64, // HPs
			51, 23, // Attack & Defense
			51, 23, // Special Attack & Defense
			28		
		)
		{
			this._height = 6;
			this._weight = 163;
		}
		#endregion
	}
	#endregion

	//Whismur Pokemon Class
	#region Whismur
	public class Whismur : Pokemon
	{
		#region Whismur Builders
		/// <summary>
		/// Whismur Builder waiting for a Nickname & a Level
		/// </summary>
		public Whismur(string nickname, int level)
		: base(
				293,
				SpecieWhismur.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whismur Builder only waiting for a Level
		/// </summary>
		public Whismur(int level)
		: base(
				293,
				SpecieWhismur.Instance, // Pokemon Specie
				"Whismur", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whismur Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Whismur() : base(
			293,
			SpecieWhismur.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}