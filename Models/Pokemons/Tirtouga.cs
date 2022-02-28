using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tirtouga Specie to store common natural stats of all Tirtougas
	#region SpecieTirtouga
	public class SpecieTirtouga : PokemonSpecie
	{
#nullable enable
		private static SpecieTirtouga? _instance = null;
#nullable restore
        public static SpecieTirtouga Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTirtouga();
                }
                return _instance;
            }
        }

		#region SpecieTirtouga Builder
		public SpecieTirtouga() : base(
			"Tirtouga",
			54, // HPs
			78, 103, // Attack & Defense
			53, 45, // Special Attack & Defense
			22			
		) {}
		#endregion
	}
	#endregion

	//Tirtouga Pokemon Class
	#region Tirtouga
	public class Tirtouga : Pokemon
	{
		#region Tirtouga Builders
		/// <summary>
		/// Tirtouga Builder waiting for a Nickname & a Level
		/// </summary>
		public Tirtouga(string nickname, int level)
		: base(
				564,
				SpecieTirtouga.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tirtouga Builder only waiting for a Level
		/// </summary>
		public Tirtouga(int level)
		: base(
				564,
				SpecieTirtouga.Instance, // Pokemon Specie
				"Tirtouga", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tirtouga Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Tirtouga() : base(
			564,
			SpecieTirtouga.Instance, // Pokemon Specie
			Water.Instance, Rock.Instance			
		) {}
		#endregion
	}
	#endregion
}