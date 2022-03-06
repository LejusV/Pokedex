using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sobble Specie to store common natural stats of all Sobbles
	#region SpecieSobble
	public class SpecieSobble : PokemonSpecie
	{
#nullable enable
		private static SpecieSobble? _instance = null;
#nullable restore
        public static SpecieSobble Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSobble();
                }
                return _instance;
            }
        }

		#region SpecieSobble Builder
		public SpecieSobble() : base(
			"Sobble",
			0.3,
			4.0,
			50, // HPs
			40, 40, // Attack & Defense
			70, 40, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Sobble Pokemon Class
	#region Sobble
	public class Sobble : Pokemon
	{
		#region Sobble Builders
		/// <summary>
		/// Sobble Builder waiting for a Nickname & a Level
		/// </summary>
		public Sobble(string nickname, int level)
		: base(
				816,
				SpecieSobble.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sobble Builder only waiting for a Level
		/// </summary>
		public Sobble(int level)
		: base(
				816,
				SpecieSobble.Instance, // Pokemon Specie
				"Sobble", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sobble Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sobble() : base(
			816,
			SpecieSobble.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}