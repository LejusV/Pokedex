using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kingler Specie to store common natural stats of all Kinglers
	#region SpecieKingler
	public class SpecieKingler : PokemonSpecie
	{
#nullable enable
		private static SpecieKingler? _instance = null;
#nullable restore
        public static SpecieKingler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKingler();
                }
                return _instance;
            }
        }

		#region SpecieKingler Builder
		public SpecieKingler() : base(
			"Kingler",
			55, // HPs
			130, 115, // Attack & Defense
			50, 50, // Special Attack & Defense
			75			
		) {}
		#endregion
	}
	#endregion

	//Kingler Pokemon Class
	#region Kingler
	public class Kingler : Pokemon
	{
		#region Kingler Builders
		/// <summary>
		/// Kingler Builder waiting for a Nickname & a Level
		/// </summary>
		public Kingler(string nickname, int level)
		: base(
				99,
				SpecieKingler.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingler Builder only waiting for a Level
		/// </summary>
		public Kingler(int level)
		: base(
				99,
				SpecieKingler.Instance, // Pokemon Specie
				"Kingler", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingler Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Kingler() : base(
			99,
			SpecieKingler.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}