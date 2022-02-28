using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cleffa Specie to store common natural stats of all Cleffas
	#region SpecieCleffa
	public class SpecieCleffa : PokemonSpecie
	{
#nullable enable
		private static SpecieCleffa? _instance = null;
#nullable restore
        public static SpecieCleffa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCleffa();
                }
                return _instance;
            }
        }

		#region SpecieCleffa Builder
		public SpecieCleffa() : base(
			"Cleffa",
			50, // HPs
			25, 28, // Attack & Defense
			45, 55, // Special Attack & Defense
			15			
		) {}
		#endregion
	}
	#endregion

	//Cleffa Pokemon Class
	#region Cleffa
	public class Cleffa : Pokemon
	{
		#region Cleffa Builders
		/// <summary>
		/// Cleffa Builder waiting for a Nickname & a Level
		/// </summary>
		public Cleffa(string nickname, int level)
		: base(
				173,
				SpecieCleffa.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cleffa Builder only waiting for a Level
		/// </summary>
		public Cleffa(int level)
		: base(
				173,
				SpecieCleffa.Instance, // Pokemon Specie
				"Cleffa", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cleffa Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Cleffa() : base(
			173,
			SpecieCleffa.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}