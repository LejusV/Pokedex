using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Poliwhirl Specie to store common natural stats of all Poliwhirls
	#region SpeciePoliwhirl
	public class SpeciePoliwhirl : PokemonSpecie
	{
#nullable enable
		private static SpeciePoliwhirl? _instance = null;
#nullable restore
        public static SpeciePoliwhirl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePoliwhirl();
                }
                return _instance;
            }
        }

		#region SpeciePoliwhirl Builder
		public SpeciePoliwhirl() : base(
			"Poliwhirl",
			65, // HPs
			65, 65, // Attack & Defense
			50, 50, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Poliwhirl Pokemon Class
	#region Poliwhirl
	public class Poliwhirl : Pokemon
	{
		#region Poliwhirl Builders
		/// <summary>
		/// Poliwhirl Builder waiting for a Nickname & a Level
		/// </summary>
		public Poliwhirl(string nickname, int level)
		: base(
				61,
				SpeciePoliwhirl.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwhirl Builder only waiting for a Level
		/// </summary>
		public Poliwhirl(int level)
		: base(
				61,
				SpeciePoliwhirl.Instance, // Pokemon Specie
				"Poliwhirl", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwhirl Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Poliwhirl() : base(
			61,
			SpeciePoliwhirl.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}