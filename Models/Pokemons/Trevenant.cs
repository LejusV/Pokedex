using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Trevenant Specie to store common natural stats of all Trevenants
	#region SpecieTrevenant
	public class SpecieTrevenant : PokemonSpecie
	{
#nullable enable
		private static SpecieTrevenant? _instance = null;
#nullable restore
        public static SpecieTrevenant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTrevenant();
                }
                return _instance;
            }
        }

		#region SpecieTrevenant Builder
		public SpecieTrevenant() : base(
			"Trevenant",
			85, // HPs
			110, 76, // Attack & Defense
			65, 82, // Special Attack & Defense
			56			
		) {}
		#endregion
	}
	#endregion

	//Trevenant Pokemon Class
	#region Trevenant
	public class Trevenant : Pokemon
	{
		#region Trevenant Builders
		/// <summary>
		/// Trevenant Builder waiting for a Nickname & a Level
		/// </summary>
		public Trevenant(string nickname, int level)
		: base(
				709,
				SpecieTrevenant.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trevenant Builder only waiting for a Level
		/// </summary>
		public Trevenant(int level)
		: base(
				709,
				SpecieTrevenant.Instance, // Pokemon Specie
				"Trevenant", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trevenant Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Trevenant() : base(
			709,
			SpecieTrevenant.Instance, // Pokemon Specie
			Ghost.Instance, Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}