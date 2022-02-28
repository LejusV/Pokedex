using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Volcarona Specie to store common natural stats of all Volcaronas
	#region SpecieVolcarona
	public class SpecieVolcarona : PokemonSpecie
	{
#nullable enable
		private static SpecieVolcarona? _instance = null;
#nullable restore
        public static SpecieVolcarona Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVolcarona();
                }
                return _instance;
            }
        }

		#region SpecieVolcarona Builder
		public SpecieVolcarona() : base(
			"Volcarona",
			85, // HPs
			60, 65, // Attack & Defense
			135, 105, // Special Attack & Defense
			100			
		) {}
		#endregion
	}
	#endregion

	//Volcarona Pokemon Class
	#region Volcarona
	public class Volcarona : Pokemon
	{
		#region Volcarona Builders
		/// <summary>
		/// Volcarona Builder waiting for a Nickname & a Level
		/// </summary>
		public Volcarona(string nickname, int level)
		: base(
				637,
				SpecieVolcarona.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcarona Builder only waiting for a Level
		/// </summary>
		public Volcarona(int level)
		: base(
				637,
				SpecieVolcarona.Instance, // Pokemon Specie
				"Volcarona", level,
				Bug.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcarona Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Volcarona() : base(
			637,
			SpecieVolcarona.Instance, // Pokemon Specie
			Bug.Instance, Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}