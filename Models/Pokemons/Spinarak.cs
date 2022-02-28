using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spinarak Specie to store common natural stats of all Spinaraks
	#region SpecieSpinarak
	public class SpecieSpinarak : PokemonSpecie
	{
#nullable enable
		private static SpecieSpinarak? _instance = null;
#nullable restore
        public static SpecieSpinarak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpinarak();
                }
                return _instance;
            }
        }

		#region SpecieSpinarak Builder
		public SpecieSpinarak() : base(
			"Spinarak",
			40, // HPs
			60, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Spinarak Pokemon Class
	#region Spinarak
	public class Spinarak : Pokemon
	{
		#region Spinarak Builders
		/// <summary>
		/// Spinarak Builder waiting for a Nickname & a Level
		/// </summary>
		public Spinarak(string nickname, int level)
		: base(
				167,
				SpecieSpinarak.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinarak Builder only waiting for a Level
		/// </summary>
		public Spinarak(int level)
		: base(
				167,
				SpecieSpinarak.Instance, // Pokemon Specie
				"Spinarak", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinarak Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Spinarak() : base(
			167,
			SpecieSpinarak.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}