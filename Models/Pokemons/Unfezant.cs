using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Unfezant Specie to store common natural stats of all Unfezants
	#region SpecieUnfezant
	public class SpecieUnfezant : PokemonSpecie
	{
#nullable enable
		private static SpecieUnfezant? _instance = null;
#nullable restore
        public static SpecieUnfezant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUnfezant();
                }
                return _instance;
            }
        }

		#region SpecieUnfezant Builder
		public SpecieUnfezant() : base(
			"Unfezant",
			80, // HPs
			115, 80, // Attack & Defense
			65, 55, // Special Attack & Defense
			93			
		) {}
		#endregion
	}
	#endregion

	//Unfezant Pokemon Class
	#region Unfezant
	public class Unfezant : Pokemon
	{
		#region Unfezant Builders
		/// <summary>
		/// Unfezant Builder waiting for a Nickname & a Level
		/// </summary>
		public Unfezant(string nickname, int level)
		: base(
				521,
				SpecieUnfezant.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unfezant Builder only waiting for a Level
		/// </summary>
		public Unfezant(int level)
		: base(
				521,
				SpecieUnfezant.Instance, // Pokemon Specie
				"Unfezant", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unfezant Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Unfezant() : base(
			521,
			SpecieUnfezant.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}