using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Grotle Specie to store common natural stats of all Grotles
	#region SpecieGrotle
	public class SpecieGrotle : PokemonSpecie
	{
#nullable enable
		private static SpecieGrotle? _instance = null;
#nullable restore
        public static SpecieGrotle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrotle();
                }
                return _instance;
            }
        }

		#region SpecieGrotle Builder
		public SpecieGrotle() : base(
			"Grotle",
			75, // HPs
			89, 85, // Attack & Defense
			55, 65, // Special Attack & Defense
			36		
		)
		{
			this._height = 11;
			this._weight = 970;
		}
		#endregion
	}
	#endregion

	//Grotle Pokemon Class
	#region Grotle
	public class Grotle : Pokemon
	{
		#region Grotle Builders
		/// <summary>
		/// Grotle Builder waiting for a Nickname & a Level
		/// </summary>
		public Grotle(string nickname, int level)
		: base(
				388,
				SpecieGrotle.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grotle Builder only waiting for a Level
		/// </summary>
		public Grotle(int level)
		: base(
				388,
				SpecieGrotle.Instance, // Pokemon Specie
				"Grotle", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grotle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Grotle() : base(
			388,
			SpecieGrotle.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}