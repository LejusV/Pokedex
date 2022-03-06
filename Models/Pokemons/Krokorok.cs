using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Krokorok Specie to store common natural stats of all Krokoroks
	#region SpecieKrokorok
	public class SpecieKrokorok : PokemonSpecie
	{
#nullable enable
		private static SpecieKrokorok? _instance = null;
#nullable restore
        public static SpecieKrokorok Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKrokorok();
                }
                return _instance;
            }
        }

		#region SpecieKrokorok Builder
		public SpecieKrokorok() : base(
			"Krokorok",
			1.0,
			33.4,
			60, // HPs
			82, 45, // Attack & Defense
			45, 45, // Special Attack & Defense
			74		
		)
		{}
		#endregion
	}
	#endregion

	//Krokorok Pokemon Class
	#region Krokorok
	public class Krokorok : Pokemon
	{
		#region Krokorok Builders
		/// <summary>
		/// Krokorok Builder waiting for a Nickname & a Level
		/// </summary>
		public Krokorok(string nickname, int level)
		: base(
				552,
				SpecieKrokorok.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krokorok Builder only waiting for a Level
		/// </summary>
		public Krokorok(int level)
		: base(
				552,
				SpecieKrokorok.Instance, // Pokemon Specie
				"Krokorok", level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krokorok Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Krokorok() : base(
			552,
			SpecieKrokorok.Instance, // Pokemon Specie
			Ground.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}