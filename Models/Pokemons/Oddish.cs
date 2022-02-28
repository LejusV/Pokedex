using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Oddish Specie to store common natural stats of all Oddishs
	#region SpecieOddish
	public class SpecieOddish : PokemonSpecie
	{
#nullable enable
		private static SpecieOddish? _instance = null;
#nullable restore
        public static SpecieOddish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOddish();
                }
                return _instance;
            }
        }

		#region SpecieOddish Builder
		public SpecieOddish() : base(
			"Oddish",
			45, // HPs
			50, 55, // Attack & Defense
			75, 65, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Oddish Pokemon Class
	#region Oddish
	public class Oddish : Pokemon
	{
		#region Oddish Builders
		/// <summary>
		/// Oddish Builder waiting for a Nickname & a Level
		/// </summary>
		public Oddish(string nickname, int level)
		: base(
				43,
				SpecieOddish.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oddish Builder only waiting for a Level
		/// </summary>
		public Oddish(int level)
		: base(
				43,
				SpecieOddish.Instance, // Pokemon Specie
				"Oddish", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oddish Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Oddish() : base(
			43,
			SpecieOddish.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}