using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Joltik Specie to store common natural stats of all Joltiks
	#region SpecieJoltik
	public class SpecieJoltik : PokemonSpecie
	{
#nullable enable
		private static SpecieJoltik? _instance = null;
#nullable restore
        public static SpecieJoltik Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJoltik();
                }
                return _instance;
            }
        }

		#region SpecieJoltik Builder
		public SpecieJoltik() : base(
			"Joltik",
			50, // HPs
			47, 50, // Attack & Defense
			57, 50, // Special Attack & Defense
			65		
		)
		{
			this._height = 1;
			this._weight = 6;
		}
		#endregion
	}
	#endregion

	//Joltik Pokemon Class
	#region Joltik
	public class Joltik : Pokemon
	{
		#region Joltik Builders
		/// <summary>
		/// Joltik Builder waiting for a Nickname & a Level
		/// </summary>
		public Joltik(string nickname, int level)
		: base(
				595,
				SpecieJoltik.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Joltik Builder only waiting for a Level
		/// </summary>
		public Joltik(int level)
		: base(
				595,
				SpecieJoltik.Instance, // Pokemon Specie
				"Joltik", level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Joltik Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Joltik() : base(
			595,
			SpecieJoltik.Instance, // Pokemon Specie
			Bug.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}