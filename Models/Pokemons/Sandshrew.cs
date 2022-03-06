using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sandshrew Specie to store common natural stats of all Sandshrews
	#region SpecieSandshrew
	public class SpecieSandshrew : PokemonSpecie
	{
#nullable enable
		private static SpecieSandshrew? _instance = null;
#nullable restore
        public static SpecieSandshrew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSandshrew();
                }
                return _instance;
            }
        }

		#region SpecieSandshrew Builder
		public SpecieSandshrew() : base(
			"Sandshrew",
			50, // HPs
			75, 85, // Attack & Defense
			20, 30, // Special Attack & Defense
			40		
		)
		{
			this._height = 6;
			this._weight = 120;
		}
		#endregion
	}
	#endregion

	//Sandshrew Pokemon Class
	#region Sandshrew
	public class Sandshrew : Pokemon
	{
		#region Sandshrew Builders
		/// <summary>
		/// Sandshrew Builder waiting for a Nickname & a Level
		/// </summary>
		public Sandshrew(string nickname, int level)
		: base(
				27,
				SpecieSandshrew.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandshrew Builder only waiting for a Level
		/// </summary>
		public Sandshrew(int level)
		: base(
				27,
				SpecieSandshrew.Instance, // Pokemon Specie
				"Sandshrew", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandshrew Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sandshrew() : base(
			27,
			SpecieSandshrew.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}