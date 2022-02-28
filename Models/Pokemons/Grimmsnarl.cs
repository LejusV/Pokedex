using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grimmsnarl Specie to store common natural stats of all Grimmsnarls
	#region SpecieGrimmsnarl
	public class SpecieGrimmsnarl : PokemonSpecie
	{
#nullable enable
		private static SpecieGrimmsnarl? _instance = null;
#nullable restore
        public static SpecieGrimmsnarl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrimmsnarl();
                }
                return _instance;
            }
        }

		#region SpecieGrimmsnarl Builder
		public SpecieGrimmsnarl() : base(
			"Grimmsnarl",
			95, // HPs
			120, 65, // Attack & Defense
			95, 75, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Grimmsnarl Pokemon Class
	#region Grimmsnarl
	public class Grimmsnarl : Pokemon
	{
		#region Grimmsnarl Builders
		/// <summary>
		/// Grimmsnarl Builder waiting for a Nickname & a Level
		/// </summary>
		public Grimmsnarl(string nickname, int level)
		: base(
				861,
				SpecieGrimmsnarl.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimmsnarl Builder only waiting for a Level
		/// </summary>
		public Grimmsnarl(int level)
		: base(
				861,
				SpecieGrimmsnarl.Instance, // Pokemon Specie
				"Grimmsnarl", level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimmsnarl Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Grimmsnarl() : base(
			861,
			SpecieGrimmsnarl.Instance, // Pokemon Specie
			Dark.Instance, Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}