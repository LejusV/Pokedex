using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Absol Specie to store common natural stats of all Absols
	#region SpecieAbsol
	public class SpecieAbsol : PokemonSpecie
	{
#nullable enable
		private static SpecieAbsol? _instance = null;
#nullable restore
        public static SpecieAbsol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAbsol();
                }
                return _instance;
            }
        }

		#region SpecieAbsol Builder
		public SpecieAbsol() : base(
			"Absol",
			65, // HPs
			130, 60, // Attack & Defense
			75, 60, // Special Attack & Defense
			75		
		)
		{
			this._height = 12;
			this._weight = 470;
		}
		#endregion
	}
	#endregion

	//Absol Pokemon Class
	#region Absol
	public class Absol : Pokemon
	{
		#region Absol Builders
		/// <summary>
		/// Absol Builder waiting for a Nickname & a Level
		/// </summary>
		public Absol(string nickname, int level)
		: base(
				359,
				SpecieAbsol.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Absol Builder only waiting for a Level
		/// </summary>
		public Absol(int level)
		: base(
				359,
				SpecieAbsol.Instance, // Pokemon Specie
				"Absol", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Absol Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Absol() : base(
			359,
			SpecieAbsol.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}