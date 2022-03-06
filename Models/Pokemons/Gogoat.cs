using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gogoat Specie to store common natural stats of all Gogoats
	#region SpecieGogoat
	public class SpecieGogoat : PokemonSpecie
	{
#nullable enable
		private static SpecieGogoat? _instance = null;
#nullable restore
        public static SpecieGogoat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGogoat();
                }
                return _instance;
            }
        }

		#region SpecieGogoat Builder
		public SpecieGogoat() : base(
			"Gogoat",
			1.7,
			91.0,
			123, // HPs
			100, 62, // Attack & Defense
			97, 81, // Special Attack & Defense
			68		
		)
		{}
		#endregion
	}
	#endregion

	//Gogoat Pokemon Class
	#region Gogoat
	public class Gogoat : Pokemon
	{
		#region Gogoat Builders
		/// <summary>
		/// Gogoat Builder waiting for a Nickname & a Level
		/// </summary>
		public Gogoat(string nickname, int level)
		: base(
				673,
				SpecieGogoat.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gogoat Builder only waiting for a Level
		/// </summary>
		public Gogoat(int level)
		: base(
				673,
				SpecieGogoat.Instance, // Pokemon Specie
				"Gogoat", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gogoat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gogoat() : base(
			673,
			SpecieGogoat.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}