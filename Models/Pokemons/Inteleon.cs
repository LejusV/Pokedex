using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Inteleon Specie to store common natural stats of all Inteleons
	#region SpecieInteleon
	public class SpecieInteleon : PokemonSpecie
	{
#nullable enable
		private static SpecieInteleon? _instance = null;
#nullable restore
        public static SpecieInteleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieInteleon();
                }
                return _instance;
            }
        }

		#region SpecieInteleon Builder
		public SpecieInteleon() : base(
			"Inteleon",
			70, // HPs
			85, 65, // Attack & Defense
			125, 65, // Special Attack & Defense
			120			
		) {}
		#endregion
	}
	#endregion

	//Inteleon Pokemon Class
	#region Inteleon
	public class Inteleon : Pokemon
	{
		#region Inteleon Builders
		/// <summary>
		/// Inteleon Builder waiting for a Nickname & a Level
		/// </summary>
		public Inteleon(string nickname, int level)
		: base(
				818,
				SpecieInteleon.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inteleon Builder only waiting for a Level
		/// </summary>
		public Inteleon(int level)
		: base(
				818,
				SpecieInteleon.Instance, // Pokemon Specie
				"Inteleon", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inteleon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Inteleon() : base(
			818,
			SpecieInteleon.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}