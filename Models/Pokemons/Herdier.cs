using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Herdier Specie to store common natural stats of all Herdiers
	#region SpecieHerdier
	public class SpecieHerdier : PokemonSpecie
	{
#nullable enable
		private static SpecieHerdier? _instance = null;
#nullable restore
        public static SpecieHerdier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHerdier();
                }
                return _instance;
            }
        }

		#region SpecieHerdier Builder
		public SpecieHerdier() : base(
			"Herdier",
			65, // HPs
			80, 65, // Attack & Defense
			35, 65, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Herdier Pokemon Class
	#region Herdier
	public class Herdier : Pokemon
	{
		#region Herdier Builders
		/// <summary>
		/// Herdier Builder waiting for a Nickname & a Level
		/// </summary>
		public Herdier(string nickname, int level)
		: base(
				507,
				SpecieHerdier.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Herdier Builder only waiting for a Level
		/// </summary>
		public Herdier(int level)
		: base(
				507,
				SpecieHerdier.Instance, // Pokemon Specie
				"Herdier", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Herdier Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Herdier() : base(
			507,
			SpecieHerdier.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}