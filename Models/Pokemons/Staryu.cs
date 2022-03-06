using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Staryu Specie to store common natural stats of all Staryus
	#region SpecieStaryu
	public class SpecieStaryu : PokemonSpecie
	{
#nullable enable
		private static SpecieStaryu? _instance = null;
#nullable restore
        public static SpecieStaryu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStaryu();
                }
                return _instance;
            }
        }

		#region SpecieStaryu Builder
		public SpecieStaryu() : base(
			"Staryu",
			0.8,
			34.5,
			30, // HPs
			45, 55, // Attack & Defense
			70, 55, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Staryu Pokemon Class
	#region Staryu
	public class Staryu : Pokemon
	{
		#region Staryu Builders
		/// <summary>
		/// Staryu Builder waiting for a Nickname & a Level
		/// </summary>
		public Staryu(string nickname, int level)
		: base(
				120,
				SpecieStaryu.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staryu Builder only waiting for a Level
		/// </summary>
		public Staryu(int level)
		: base(
				120,
				SpecieStaryu.Instance, // Pokemon Specie
				"Staryu", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staryu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Staryu() : base(
			120,
			SpecieStaryu.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}