using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Flareon Specie to store common natural stats of all Flareons
	#region SpecieFlareon
	public class SpecieFlareon : PokemonSpecie
	{
#nullable enable
		private static SpecieFlareon? _instance = null;
#nullable restore
        public static SpecieFlareon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlareon();
                }
                return _instance;
            }
        }

		#region SpecieFlareon Builder
		public SpecieFlareon() : base(
			"Flareon",
			65, // HPs
			130, 60, // Attack & Defense
			95, 110, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Flareon Pokemon Class
	#region Flareon
	public class Flareon : Pokemon
	{
		#region Flareon Builders
		/// <summary>
		/// Flareon Builder waiting for a Nickname & a Level
		/// </summary>
		public Flareon(string nickname, int level)
		: base(
				136,
				SpecieFlareon.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flareon Builder only waiting for a Level
		/// </summary>
		public Flareon(int level)
		: base(
				136,
				SpecieFlareon.Instance, // Pokemon Specie
				"Flareon", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flareon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Flareon() : base(
			136,
			SpecieFlareon.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}