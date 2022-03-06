using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Teddiursa Specie to store common natural stats of all Teddiursas
	#region SpecieTeddiursa
	public class SpecieTeddiursa : PokemonSpecie
	{
#nullable enable
		private static SpecieTeddiursa? _instance = null;
#nullable restore
        public static SpecieTeddiursa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTeddiursa();
                }
                return _instance;
            }
        }

		#region SpecieTeddiursa Builder
		public SpecieTeddiursa() : base(
			"Teddiursa",
			60, // HPs
			80, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			40		
		)
		{
			this._height = 6;
			this._weight = 88;
		}
		#endregion
	}
	#endregion

	//Teddiursa Pokemon Class
	#region Teddiursa
	public class Teddiursa : Pokemon
	{
		#region Teddiursa Builders
		/// <summary>
		/// Teddiursa Builder waiting for a Nickname & a Level
		/// </summary>
		public Teddiursa(string nickname, int level)
		: base(
				216,
				SpecieTeddiursa.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Teddiursa Builder only waiting for a Level
		/// </summary>
		public Teddiursa(int level)
		: base(
				216,
				SpecieTeddiursa.Instance, // Pokemon Specie
				"Teddiursa", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Teddiursa Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Teddiursa() : base(
			216,
			SpecieTeddiursa.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}