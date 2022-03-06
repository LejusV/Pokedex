using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kangaskhan Specie to store common natural stats of all Kangaskhans
	#region SpecieKangaskhan
	public class SpecieKangaskhan : PokemonSpecie
	{
#nullable enable
		private static SpecieKangaskhan? _instance = null;
#nullable restore
        public static SpecieKangaskhan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKangaskhan();
                }
                return _instance;
            }
        }

		#region SpecieKangaskhan Builder
		public SpecieKangaskhan() : base(
			"Kangaskhan",
			105, // HPs
			95, 80, // Attack & Defense
			40, 80, // Special Attack & Defense
			90		
		)
		{
			this._height = 22;
			this._weight = 800;
		}
		#endregion
	}
	#endregion

	//Kangaskhan Pokemon Class
	#region Kangaskhan
	public class Kangaskhan : Pokemon
	{
		#region Kangaskhan Builders
		/// <summary>
		/// Kangaskhan Builder waiting for a Nickname & a Level
		/// </summary>
		public Kangaskhan(string nickname, int level)
		: base(
				115,
				SpecieKangaskhan.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kangaskhan Builder only waiting for a Level
		/// </summary>
		public Kangaskhan(int level)
		: base(
				115,
				SpecieKangaskhan.Instance, // Pokemon Specie
				"Kangaskhan", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kangaskhan Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kangaskhan() : base(
			115,
			SpecieKangaskhan.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}