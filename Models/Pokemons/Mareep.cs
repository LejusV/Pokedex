using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mareep Specie to store common natural stats of all Mareeps
	#region SpecieMareep
	public class SpecieMareep : PokemonSpecie
	{
#nullable enable
		private static SpecieMareep? _instance = null;
#nullable restore
        public static SpecieMareep Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMareep();
                }
                return _instance;
            }
        }

		#region SpecieMareep Builder
		public SpecieMareep() : base(
			"Mareep",
			55, // HPs
			40, 40, // Attack & Defense
			65, 45, // Special Attack & Defense
			35			
		) {}
		#endregion
	}
	#endregion

	//Mareep Pokemon Class
	#region Mareep
	public class Mareep : Pokemon
	{
		#region Mareep Builders
		/// <summary>
		/// Mareep Builder waiting for a Nickname & a Level
		/// </summary>
		public Mareep(string nickname, int level)
		: base(
				179,
				SpecieMareep.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareep Builder only waiting for a Level
		/// </summary>
		public Mareep(int level)
		: base(
				179,
				SpecieMareep.Instance, // Pokemon Specie
				"Mareep", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareep Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Mareep() : base(
			179,
			SpecieMareep.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}