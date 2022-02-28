using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sandslash Specie to store common natural stats of all Sandslashs
	#region SpecieSandslash
	public class SpecieSandslash : PokemonSpecie
	{
#nullable enable
		private static SpecieSandslash? _instance = null;
#nullable restore
        public static SpecieSandslash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSandslash();
                }
                return _instance;
            }
        }

		#region SpecieSandslash Builder
		public SpecieSandslash() : base(
			"Sandslash",
			75, // HPs
			100, 110, // Attack & Defense
			45, 55, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Sandslash Pokemon Class
	#region Sandslash
	public class Sandslash : Pokemon
	{
		#region Sandslash Builders
		/// <summary>
		/// Sandslash Builder waiting for a Nickname & a Level
		/// </summary>
		public Sandslash(string nickname, int level)
		: base(
				28,
				SpecieSandslash.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandslash Builder only waiting for a Level
		/// </summary>
		public Sandslash(int level)
		: base(
				28,
				SpecieSandslash.Instance, // Pokemon Specie
				"Sandslash", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandslash Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Sandslash() : base(
			28,
			SpecieSandslash.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}