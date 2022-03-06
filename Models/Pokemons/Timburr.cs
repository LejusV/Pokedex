using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Timburr Specie to store common natural stats of all Timburrs
	#region SpecieTimburr
	public class SpecieTimburr : PokemonSpecie
	{
#nullable enable
		private static SpecieTimburr? _instance = null;
#nullable restore
        public static SpecieTimburr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTimburr();
                }
                return _instance;
            }
        }

		#region SpecieTimburr Builder
		public SpecieTimburr() : base(
			"Timburr",
			0.6,
			12.5,
			75, // HPs
			80, 55, // Attack & Defense
			25, 35, // Special Attack & Defense
			35		
		)
		{}
		#endregion
	}
	#endregion

	//Timburr Pokemon Class
	#region Timburr
	public class Timburr : Pokemon
	{
		#region Timburr Builders
		/// <summary>
		/// Timburr Builder waiting for a Nickname & a Level
		/// </summary>
		public Timburr(string nickname, int level)
		: base(
				532,
				SpecieTimburr.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Timburr Builder only waiting for a Level
		/// </summary>
		public Timburr(int level)
		: base(
				532,
				SpecieTimburr.Instance, // Pokemon Specie
				"Timburr", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Timburr Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Timburr() : base(
			532,
			SpecieTimburr.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}