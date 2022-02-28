using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magnezone Specie to store common natural stats of all Magnezones
	#region SpecieMagnezone
	public class SpecieMagnezone : PokemonSpecie
	{
#nullable enable
		private static SpecieMagnezone? _instance = null;
#nullable restore
        public static SpecieMagnezone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagnezone();
                }
                return _instance;
            }
        }

		#region SpecieMagnezone Builder
		public SpecieMagnezone() : base(
			"Magnezone",
			70, // HPs
			70, 115, // Attack & Defense
			130, 90, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Magnezone Pokemon Class
	#region Magnezone
	public class Magnezone : Pokemon
	{
		#region Magnezone Builders
		/// <summary>
		/// Magnezone Builder waiting for a Nickname & a Level
		/// </summary>
		public Magnezone(string nickname, int level)
		: base(
				462,
				SpecieMagnezone.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnezone Builder only waiting for a Level
		/// </summary>
		public Magnezone(int level)
		: base(
				462,
				SpecieMagnezone.Instance, // Pokemon Specie
				"Magnezone", level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnezone Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Magnezone() : base(
			462,
			SpecieMagnezone.Instance, // Pokemon Specie
			Electric.Instance, Steel.Instance			
		) {}
		#endregion
	}
	#endregion
}