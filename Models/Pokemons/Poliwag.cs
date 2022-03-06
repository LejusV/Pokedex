using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Poliwag Specie to store common natural stats of all Poliwags
	#region SpeciePoliwag
	public class SpeciePoliwag : PokemonSpecie
	{
#nullable enable
		private static SpeciePoliwag? _instance = null;
#nullable restore
        public static SpeciePoliwag Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePoliwag();
                }
                return _instance;
            }
        }

		#region SpeciePoliwag Builder
		public SpeciePoliwag() : base(
			"Poliwag",
			0.6,
			12.4,
			40, // HPs
			50, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Poliwag Pokemon Class
	#region Poliwag
	public class Poliwag : Pokemon
	{
		#region Poliwag Builders
		/// <summary>
		/// Poliwag Builder waiting for a Nickname & a Level
		/// </summary>
		public Poliwag(string nickname, int level)
		: base(
				60,
				SpeciePoliwag.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwag Builder only waiting for a Level
		/// </summary>
		public Poliwag(int level)
		: base(
				60,
				SpeciePoliwag.Instance, // Pokemon Specie
				"Poliwag", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwag Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Poliwag() : base(
			60,
			SpeciePoliwag.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}