using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spearow Specie to store common natural stats of all Spearows
	#region SpecieSpearow
	public class SpecieSpearow : PokemonSpecie
	{
#nullable enable
		private static SpecieSpearow? _instance = null;
#nullable restore
        public static SpecieSpearow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpearow();
                }
                return _instance;
            }
        }

		#region SpecieSpearow Builder
		public SpecieSpearow() : base(
			"Spearow",
			40, // HPs
			60, 30, // Attack & Defense
			31, 31, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Spearow Pokemon Class
	#region Spearow
	public class Spearow : Pokemon
	{
		#region Spearow Builders
		/// <summary>
		/// Spearow Builder waiting for a Nickname & a Level
		/// </summary>
		public Spearow(string nickname, int level)
		: base(
				21,
				SpecieSpearow.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spearow Builder only waiting for a Level
		/// </summary>
		public Spearow(int level)
		: base(
				21,
				SpecieSpearow.Instance, // Pokemon Specie
				"Spearow", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spearow Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Spearow() : base(
			21,
			SpecieSpearow.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}