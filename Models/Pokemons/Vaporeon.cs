using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Vaporeon Specie to store common natural stats of all Vaporeons
	#region SpecieVaporeon
	public class SpecieVaporeon : PokemonSpecie
	{
#nullable enable
		private static SpecieVaporeon? _instance = null;
#nullable restore
        public static SpecieVaporeon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVaporeon();
                }
                return _instance;
            }
        }

		#region SpecieVaporeon Builder
		public SpecieVaporeon() : base(
			"Vaporeon",
			130, // HPs
			65, 60, // Attack & Defense
			110, 95, // Special Attack & Defense
			65		
		)
		{
			this._height = 10;
			this._weight = 290;
		}
		#endregion
	}
	#endregion

	//Vaporeon Pokemon Class
	#region Vaporeon
	public class Vaporeon : Pokemon
	{
		#region Vaporeon Builders
		/// <summary>
		/// Vaporeon Builder waiting for a Nickname & a Level
		/// </summary>
		public Vaporeon(string nickname, int level)
		: base(
				134,
				SpecieVaporeon.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vaporeon Builder only waiting for a Level
		/// </summary>
		public Vaporeon(int level)
		: base(
				134,
				SpecieVaporeon.Instance, // Pokemon Specie
				"Vaporeon", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vaporeon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Vaporeon() : base(
			134,
			SpecieVaporeon.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}