using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Staravia Specie to store common natural stats of all Staravias
	#region SpecieStaravia
	public class SpecieStaravia : PokemonSpecie
	{
#nullable enable
		private static SpecieStaravia? _instance = null;
#nullable restore
        public static SpecieStaravia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStaravia();
                }
                return _instance;
            }
        }

		#region SpecieStaravia Builder
		public SpecieStaravia() : base(
			"Staravia",
			55, // HPs
			75, 50, // Attack & Defense
			40, 40, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Staravia Pokemon Class
	#region Staravia
	public class Staravia : Pokemon
	{
		#region Staravia Builders
		/// <summary>
		/// Staravia Builder waiting for a Nickname & a Level
		/// </summary>
		public Staravia(string nickname, int level)
		: base(
				397,
				SpecieStaravia.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staravia Builder only waiting for a Level
		/// </summary>
		public Staravia(int level)
		: base(
				397,
				SpecieStaravia.Instance, // Pokemon Specie
				"Staravia", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staravia Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Staravia() : base(
			397,
			SpecieStaravia.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}