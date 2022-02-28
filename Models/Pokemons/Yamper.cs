using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Yamper Specie to store common natural stats of all Yampers
	#region SpecieYamper
	public class SpecieYamper : PokemonSpecie
	{
#nullable enable
		private static SpecieYamper? _instance = null;
#nullable restore
        public static SpecieYamper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYamper();
                }
                return _instance;
            }
        }

		#region SpecieYamper Builder
		public SpecieYamper() : base(
			"Yamper",
			59, // HPs
			45, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			26			
		) {}
		#endregion
	}
	#endregion

	//Yamper Pokemon Class
	#region Yamper
	public class Yamper : Pokemon
	{
		#region Yamper Builders
		/// <summary>
		/// Yamper Builder waiting for a Nickname & a Level
		/// </summary>
		public Yamper(string nickname, int level)
		: base(
				835,
				SpecieYamper.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamper Builder only waiting for a Level
		/// </summary>
		public Yamper(int level)
		: base(
				835,
				SpecieYamper.Instance, // Pokemon Specie
				"Yamper", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamper Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Yamper() : base(
			835,
			SpecieYamper.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}