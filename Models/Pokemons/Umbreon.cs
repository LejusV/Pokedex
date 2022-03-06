using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Umbreon Specie to store common natural stats of all Umbreons
	#region SpecieUmbreon
	public class SpecieUmbreon : PokemonSpecie
	{
#nullable enable
		private static SpecieUmbreon? _instance = null;
#nullable restore
        public static SpecieUmbreon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUmbreon();
                }
                return _instance;
            }
        }

		#region SpecieUmbreon Builder
		public SpecieUmbreon() : base(
			"Umbreon",
			1.0,
			27.0,
			95, // HPs
			65, 110, // Attack & Defense
			60, 130, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Umbreon Pokemon Class
	#region Umbreon
	public class Umbreon : Pokemon
	{
		#region Umbreon Builders
		/// <summary>
		/// Umbreon Builder waiting for a Nickname & a Level
		/// </summary>
		public Umbreon(string nickname, int level)
		: base(
				197,
				SpecieUmbreon.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Umbreon Builder only waiting for a Level
		/// </summary>
		public Umbreon(int level)
		: base(
				197,
				SpecieUmbreon.Instance, // Pokemon Specie
				"Umbreon", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Umbreon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Umbreon() : base(
			197,
			SpecieUmbreon.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}