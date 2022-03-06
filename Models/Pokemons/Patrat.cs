using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Patrat Specie to store common natural stats of all Patrats
	#region SpeciePatrat
	public class SpeciePatrat : PokemonSpecie
	{
#nullable enable
		private static SpeciePatrat? _instance = null;
#nullable restore
        public static SpeciePatrat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePatrat();
                }
                return _instance;
            }
        }

		#region SpeciePatrat Builder
		public SpeciePatrat() : base(
			"Patrat",
			45, // HPs
			55, 39, // Attack & Defense
			35, 39, // Special Attack & Defense
			42		
		)
		{
			this._height = 5;
			this._weight = 116;
		}
		#endregion
	}
	#endregion

	//Patrat Pokemon Class
	#region Patrat
	public class Patrat : Pokemon
	{
		#region Patrat Builders
		/// <summary>
		/// Patrat Builder waiting for a Nickname & a Level
		/// </summary>
		public Patrat(string nickname, int level)
		: base(
				504,
				SpeciePatrat.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Patrat Builder only waiting for a Level
		/// </summary>
		public Patrat(int level)
		: base(
				504,
				SpeciePatrat.Instance, // Pokemon Specie
				"Patrat", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Patrat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Patrat() : base(
			504,
			SpeciePatrat.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}