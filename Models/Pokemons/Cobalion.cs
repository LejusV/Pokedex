using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cobalion Specie to store common natural stats of all Cobalions
	#region SpecieCobalion
	public class SpecieCobalion : PokemonSpecie
	{
#nullable enable
		private static SpecieCobalion? _instance = null;
#nullable restore
        public static SpecieCobalion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCobalion();
                }
                return _instance;
            }
        }

		#region SpecieCobalion Builder
		public SpecieCobalion() : base(
			"Cobalion",
			91, // HPs
			90, 129, // Attack & Defense
			90, 72, // Special Attack & Defense
			108			
		) {}
		#endregion
	}
	#endregion

	//Cobalion Pokemon Class
	#region Cobalion
	public class Cobalion : Pokemon
	{
		#region Cobalion Builders
		/// <summary>
		/// Cobalion Builder waiting for a Nickname & a Level
		/// </summary>
		public Cobalion(string nickname, int level)
		: base(
				638,
				SpecieCobalion.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cobalion Builder only waiting for a Level
		/// </summary>
		public Cobalion(int level)
		: base(
				638,
				SpecieCobalion.Instance, // Pokemon Specie
				"Cobalion", level,
				Steel.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cobalion Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Cobalion() : base(
			638,
			SpecieCobalion.Instance, // Pokemon Specie
			Steel.Instance, Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}