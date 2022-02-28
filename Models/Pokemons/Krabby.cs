using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Krabby Specie to store common natural stats of all Krabbys
	#region SpecieKrabby
	public class SpecieKrabby : PokemonSpecie
	{
#nullable enable
		private static SpecieKrabby? _instance = null;
#nullable restore
        public static SpecieKrabby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKrabby();
                }
                return _instance;
            }
        }

		#region SpecieKrabby Builder
		public SpecieKrabby() : base(
			"Krabby",
			30, // HPs
			105, 90, // Attack & Defense
			25, 25, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Krabby Pokemon Class
	#region Krabby
	public class Krabby : Pokemon
	{
		#region Krabby Builders
		/// <summary>
		/// Krabby Builder waiting for a Nickname & a Level
		/// </summary>
		public Krabby(string nickname, int level)
		: base(
				98,
				SpecieKrabby.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krabby Builder only waiting for a Level
		/// </summary>
		public Krabby(int level)
		: base(
				98,
				SpecieKrabby.Instance, // Pokemon Specie
				"Krabby", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krabby Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Krabby() : base(
			98,
			SpecieKrabby.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}