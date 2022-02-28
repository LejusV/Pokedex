using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magcargo Specie to store common natural stats of all Magcargos
	#region SpecieMagcargo
	public class SpecieMagcargo : PokemonSpecie
	{
#nullable enable
		private static SpecieMagcargo? _instance = null;
#nullable restore
        public static SpecieMagcargo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagcargo();
                }
                return _instance;
            }
        }

		#region SpecieMagcargo Builder
		public SpecieMagcargo() : base(
			"Magcargo",
			60, // HPs
			50, 120, // Attack & Defense
			90, 80, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Magcargo Pokemon Class
	#region Magcargo
	public class Magcargo : Pokemon
	{
		#region Magcargo Builders
		/// <summary>
		/// Magcargo Builder waiting for a Nickname & a Level
		/// </summary>
		public Magcargo(string nickname, int level)
		: base(
				219,
				SpecieMagcargo.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magcargo Builder only waiting for a Level
		/// </summary>
		public Magcargo(int level)
		: base(
				219,
				SpecieMagcargo.Instance, // Pokemon Specie
				"Magcargo", level,
				Fire.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magcargo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Magcargo() : base(
			219,
			SpecieMagcargo.Instance, // Pokemon Specie
			Fire.Instance, Rock.Instance			
		) {}
		#endregion
	}
	#endregion
}