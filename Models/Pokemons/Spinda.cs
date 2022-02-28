using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spinda Specie to store common natural stats of all Spindas
	#region SpecieSpinda
	public class SpecieSpinda : PokemonSpecie
	{
#nullable enable
		private static SpecieSpinda? _instance = null;
#nullable restore
        public static SpecieSpinda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpinda();
                }
                return _instance;
            }
        }

		#region SpecieSpinda Builder
		public SpecieSpinda() : base(
			"Spinda",
			60, // HPs
			60, 60, // Attack & Defense
			60, 60, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Spinda Pokemon Class
	#region Spinda
	public class Spinda : Pokemon
	{
		#region Spinda Builders
		/// <summary>
		/// Spinda Builder waiting for a Nickname & a Level
		/// </summary>
		public Spinda(string nickname, int level)
		: base(
				327,
				SpecieSpinda.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinda Builder only waiting for a Level
		/// </summary>
		public Spinda(int level)
		: base(
				327,
				SpecieSpinda.Instance, // Pokemon Specie
				"Spinda", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinda Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Spinda() : base(
			327,
			SpecieSpinda.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}