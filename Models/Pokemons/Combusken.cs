using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Combusken Specie to store common natural stats of all Combuskens
	#region SpecieCombusken
	public class SpecieCombusken : PokemonSpecie
	{
#nullable enable
		private static SpecieCombusken? _instance = null;
#nullable restore
        public static SpecieCombusken Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCombusken();
                }
                return _instance;
            }
        }

		#region SpecieCombusken Builder
		public SpecieCombusken() : base(
			"Combusken",
			60, // HPs
			85, 60, // Attack & Defense
			85, 60, // Special Attack & Defense
			55			
		) {}
		#endregion
	}
	#endregion

	//Combusken Pokemon Class
	#region Combusken
	public class Combusken : Pokemon
	{
		#region Combusken Builders
		/// <summary>
		/// Combusken Builder waiting for a Nickname & a Level
		/// </summary>
		public Combusken(string nickname, int level)
		: base(
				256,
				SpecieCombusken.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combusken Builder only waiting for a Level
		/// </summary>
		public Combusken(int level)
		: base(
				256,
				SpecieCombusken.Instance, // Pokemon Specie
				"Combusken", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combusken Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Combusken() : base(
			256,
			SpecieCombusken.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}