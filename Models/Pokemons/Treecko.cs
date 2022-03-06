using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Treecko Specie to store common natural stats of all Treeckos
	#region SpecieTreecko
	public class SpecieTreecko : PokemonSpecie
	{
#nullable enable
		private static SpecieTreecko? _instance = null;
#nullable restore
        public static SpecieTreecko Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTreecko();
                }
                return _instance;
            }
        }

		#region SpecieTreecko Builder
		public SpecieTreecko() : base(
			"Treecko",
			0.5,
			5.0,
			40, // HPs
			45, 35, // Attack & Defense
			65, 55, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Treecko Pokemon Class
	#region Treecko
	public class Treecko : Pokemon
	{
		#region Treecko Builders
		/// <summary>
		/// Treecko Builder waiting for a Nickname & a Level
		/// </summary>
		public Treecko(string nickname, int level)
		: base(
				252,
				SpecieTreecko.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Treecko Builder only waiting for a Level
		/// </summary>
		public Treecko(int level)
		: base(
				252,
				SpecieTreecko.Instance, // Pokemon Specie
				"Treecko", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Treecko Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Treecko() : base(
			252,
			SpecieTreecko.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}