using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Klink Specie to store common natural stats of all Klinks
	#region SpecieKlink
	public class SpecieKlink : PokemonSpecie
	{
#nullable enable
		private static SpecieKlink? _instance = null;
#nullable restore
        public static SpecieKlink Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKlink();
                }
                return _instance;
            }
        }

		#region SpecieKlink Builder
		public SpecieKlink() : base(
			"Klink",
			0.3,
			21.0,
			40, // HPs
			55, 70, // Attack & Defense
			45, 60, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Klink Pokemon Class
	#region Klink
	public class Klink : Pokemon
	{
		#region Klink Builders
		/// <summary>
		/// Klink Builder waiting for a Nickname & a Level
		/// </summary>
		public Klink(string nickname, int level)
		: base(
				599,
				SpecieKlink.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klink Builder only waiting for a Level
		/// </summary>
		public Klink(int level)
		: base(
				599,
				SpecieKlink.Instance, // Pokemon Specie
				"Klink", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klink Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Klink() : base(
			599,
			SpecieKlink.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}