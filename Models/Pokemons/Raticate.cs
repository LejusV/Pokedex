using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Raticate Specie to store common natural stats of all Raticates
	#region SpecieRaticate
	public class SpecieRaticate : PokemonSpecie
	{
#nullable enable
		private static SpecieRaticate? _instance = null;
#nullable restore
        public static SpecieRaticate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRaticate();
                }
                return _instance;
            }
        }

		#region SpecieRaticate Builder
		public SpecieRaticate() : base(
			"Raticate",
			55, // HPs
			81, 60, // Attack & Defense
			50, 70, // Special Attack & Defense
			97			
		) {}
		#endregion
	}
	#endregion

	//Raticate Pokemon Class
	#region Raticate
	public class Raticate : Pokemon
	{
		#region Raticate Builders
		/// <summary>
		/// Raticate Builder waiting for a Nickname & a Level
		/// </summary>
		public Raticate(string nickname, int level)
		: base(
				20,
				SpecieRaticate.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raticate Builder only waiting for a Level
		/// </summary>
		public Raticate(int level)
		: base(
				20,
				SpecieRaticate.Instance, // Pokemon Specie
				"Raticate", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raticate Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Raticate() : base(
			20,
			SpecieRaticate.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}