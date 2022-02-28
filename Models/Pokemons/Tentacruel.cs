using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tentacruel Specie to store common natural stats of all Tentacruels
	#region SpecieTentacruel
	public class SpecieTentacruel : PokemonSpecie
	{
#nullable enable
		private static SpecieTentacruel? _instance = null;
#nullable restore
        public static SpecieTentacruel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTentacruel();
                }
                return _instance;
            }
        }

		#region SpecieTentacruel Builder
		public SpecieTentacruel() : base(
			"Tentacruel",
			80, // HPs
			70, 65, // Attack & Defense
			80, 120, // Special Attack & Defense
			100			
		) {}
		#endregion
	}
	#endregion

	//Tentacruel Pokemon Class
	#region Tentacruel
	public class Tentacruel : Pokemon
	{
		#region Tentacruel Builders
		/// <summary>
		/// Tentacruel Builder waiting for a Nickname & a Level
		/// </summary>
		public Tentacruel(string nickname, int level)
		: base(
				73,
				SpecieTentacruel.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacruel Builder only waiting for a Level
		/// </summary>
		public Tentacruel(int level)
		: base(
				73,
				SpecieTentacruel.Instance, // Pokemon Specie
				"Tentacruel", level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacruel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Tentacruel() : base(
			73,
			SpecieTentacruel.Instance, // Pokemon Specie
			Water.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}