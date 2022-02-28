using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hariyama Specie to store common natural stats of all Hariyamas
	#region SpecieHariyama
	public class SpecieHariyama : PokemonSpecie
	{
#nullable enable
		private static SpecieHariyama? _instance = null;
#nullable restore
        public static SpecieHariyama Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHariyama();
                }
                return _instance;
            }
        }

		#region SpecieHariyama Builder
		public SpecieHariyama() : base(
			"Hariyama",
			144, // HPs
			120, 60, // Attack & Defense
			40, 60, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Hariyama Pokemon Class
	#region Hariyama
	public class Hariyama : Pokemon
	{
		#region Hariyama Builders
		/// <summary>
		/// Hariyama Builder waiting for a Nickname & a Level
		/// </summary>
		public Hariyama(string nickname, int level)
		: base(
				297,
				SpecieHariyama.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hariyama Builder only waiting for a Level
		/// </summary>
		public Hariyama(int level)
		: base(
				297,
				SpecieHariyama.Instance, // Pokemon Specie
				"Hariyama", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hariyama Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Hariyama() : base(
			297,
			SpecieHariyama.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}