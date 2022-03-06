using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Heracross Specie to store common natural stats of all Heracrosss
	#region SpecieHeracross
	public class SpecieHeracross : PokemonSpecie
	{
#nullable enable
		private static SpecieHeracross? _instance = null;
#nullable restore
        public static SpecieHeracross Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHeracross();
                }
                return _instance;
            }
        }

		#region SpecieHeracross Builder
		public SpecieHeracross() : base(
			"Heracross",
			80, // HPs
			125, 75, // Attack & Defense
			40, 95, // Special Attack & Defense
			85		
		)
		{
			this._height = 15;
			this._weight = 540;
		}
		#endregion
	}
	#endregion

	//Heracross Pokemon Class
	#region Heracross
	public class Heracross : Pokemon
	{
		#region Heracross Builders
		/// <summary>
		/// Heracross Builder waiting for a Nickname & a Level
		/// </summary>
		public Heracross(string nickname, int level)
		: base(
				214,
				SpecieHeracross.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heracross Builder only waiting for a Level
		/// </summary>
		public Heracross(int level)
		: base(
				214,
				SpecieHeracross.Instance, // Pokemon Specie
				"Heracross", level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heracross Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Heracross() : base(
			214,
			SpecieHeracross.Instance, // Pokemon Specie
			Bug.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}