using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zubat Specie to store common natural stats of all Zubats
	#region SpecieZubat
	public class SpecieZubat : PokemonSpecie
	{
#nullable enable
		private static SpecieZubat? _instance = null;
#nullable restore
        public static SpecieZubat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZubat();
                }
                return _instance;
            }
        }

		#region SpecieZubat Builder
		public SpecieZubat() : base(
			"Zubat",
			40, // HPs
			45, 35, // Attack & Defense
			30, 40, // Special Attack & Defense
			55			
		) {}
		#endregion
	}
	#endregion

	//Zubat Pokemon Class
	#region Zubat
	public class Zubat : Pokemon
	{
		#region Zubat Builders
		/// <summary>
		/// Zubat Builder waiting for a Nickname & a Level
		/// </summary>
		public Zubat(string nickname, int level)
		: base(
				41,
				SpecieZubat.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zubat Builder only waiting for a Level
		/// </summary>
		public Zubat(int level)
		: base(
				41,
				SpecieZubat.Instance, // Pokemon Specie
				"Zubat", level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zubat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Zubat() : base(
			41,
			SpecieZubat.Instance, // Pokemon Specie
			Poison.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}