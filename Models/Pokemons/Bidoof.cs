using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bidoof Specie to store common natural stats of all Bidoofs
	#region SpecieBidoof
	public class SpecieBidoof : PokemonSpecie
	{
#nullable enable
		private static SpecieBidoof? _instance = null;
#nullable restore
        public static SpecieBidoof Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBidoof();
                }
                return _instance;
            }
        }

		#region SpecieBidoof Builder
		public SpecieBidoof() : base(
			"Bidoof",
			59, // HPs
			45, 40, // Attack & Defense
			35, 40, // Special Attack & Defense
			31			
		) {}
		#endregion
	}
	#endregion

	//Bidoof Pokemon Class
	#region Bidoof
	public class Bidoof : Pokemon
	{
		#region Bidoof Builders
		/// <summary>
		/// Bidoof Builder waiting for a Nickname & a Level
		/// </summary>
		public Bidoof(string nickname, int level)
		: base(
				399,
				SpecieBidoof.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bidoof Builder only waiting for a Level
		/// </summary>
		public Bidoof(int level)
		: base(
				399,
				SpecieBidoof.Instance, // Pokemon Specie
				"Bidoof", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bidoof Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Bidoof() : base(
			399,
			SpecieBidoof.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}