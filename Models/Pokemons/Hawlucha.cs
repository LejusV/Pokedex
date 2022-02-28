using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hawlucha Specie to store common natural stats of all Hawluchas
	#region SpecieHawlucha
	public class SpecieHawlucha : PokemonSpecie
	{
#nullable enable
		private static SpecieHawlucha? _instance = null;
#nullable restore
        public static SpecieHawlucha Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHawlucha();
                }
                return _instance;
            }
        }

		#region SpecieHawlucha Builder
		public SpecieHawlucha() : base(
			"Hawlucha",
			78, // HPs
			92, 75, // Attack & Defense
			74, 63, // Special Attack & Defense
			118			
		) {}
		#endregion
	}
	#endregion

	//Hawlucha Pokemon Class
	#region Hawlucha
	public class Hawlucha : Pokemon
	{
		#region Hawlucha Builders
		/// <summary>
		/// Hawlucha Builder waiting for a Nickname & a Level
		/// </summary>
		public Hawlucha(string nickname, int level)
		: base(
				701,
				SpecieHawlucha.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hawlucha Builder only waiting for a Level
		/// </summary>
		public Hawlucha(int level)
		: base(
				701,
				SpecieHawlucha.Instance, // Pokemon Specie
				"Hawlucha", level,
				Fighting.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hawlucha Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Hawlucha() : base(
			701,
			SpecieHawlucha.Instance, // Pokemon Specie
			Fighting.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}