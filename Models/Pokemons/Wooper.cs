using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wooper Specie to store common natural stats of all Woopers
	#region SpecieWooper
	public class SpecieWooper : PokemonSpecie
	{
#nullable enable
		private static SpecieWooper? _instance = null;
#nullable restore
        public static SpecieWooper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWooper();
                }
                return _instance;
            }
        }

		#region SpecieWooper Builder
		public SpecieWooper() : base(
			"Wooper",
			55, // HPs
			45, 45, // Attack & Defense
			25, 25, // Special Attack & Defense
			15			
		) {}
		#endregion
	}
	#endregion

	//Wooper Pokemon Class
	#region Wooper
	public class Wooper : Pokemon
	{
		#region Wooper Builders
		/// <summary>
		/// Wooper Builder waiting for a Nickname & a Level
		/// </summary>
		public Wooper(string nickname, int level)
		: base(
				194,
				SpecieWooper.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooper Builder only waiting for a Level
		/// </summary>
		public Wooper(int level)
		: base(
				194,
				SpecieWooper.Instance, // Pokemon Specie
				"Wooper", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooper Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Wooper() : base(
			194,
			SpecieWooper.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}