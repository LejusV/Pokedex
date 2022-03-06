using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Vigoroth Specie to store common natural stats of all Vigoroths
	#region SpecieVigoroth
	public class SpecieVigoroth : PokemonSpecie
	{
#nullable enable
		private static SpecieVigoroth? _instance = null;
#nullable restore
        public static SpecieVigoroth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVigoroth();
                }
                return _instance;
            }
        }

		#region SpecieVigoroth Builder
		public SpecieVigoroth() : base(
			"Vigoroth",
			1.4,
			46.5,
			80, // HPs
			80, 80, // Attack & Defense
			55, 55, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Vigoroth Pokemon Class
	#region Vigoroth
	public class Vigoroth : Pokemon
	{
		#region Vigoroth Builders
		/// <summary>
		/// Vigoroth Builder waiting for a Nickname & a Level
		/// </summary>
		public Vigoroth(string nickname, int level)
		: base(
				288,
				SpecieVigoroth.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vigoroth Builder only waiting for a Level
		/// </summary>
		public Vigoroth(int level)
		: base(
				288,
				SpecieVigoroth.Instance, // Pokemon Specie
				"Vigoroth", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vigoroth Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Vigoroth() : base(
			288,
			SpecieVigoroth.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}