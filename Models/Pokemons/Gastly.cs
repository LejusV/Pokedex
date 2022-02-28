using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gastly Specie to store common natural stats of all Gastlys
	#region SpecieGastly
	public class SpecieGastly : PokemonSpecie
	{
#nullable enable
		private static SpecieGastly? _instance = null;
#nullable restore
        public static SpecieGastly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGastly();
                }
                return _instance;
            }
        }

		#region SpecieGastly Builder
		public SpecieGastly() : base(
			"Gastly",
			30, // HPs
			35, 30, // Attack & Defense
			100, 35, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Gastly Pokemon Class
	#region Gastly
	public class Gastly : Pokemon
	{
		#region Gastly Builders
		/// <summary>
		/// Gastly Builder waiting for a Nickname & a Level
		/// </summary>
		public Gastly(string nickname, int level)
		: base(
				92,
				SpecieGastly.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastly Builder only waiting for a Level
		/// </summary>
		public Gastly(int level)
		: base(
				92,
				SpecieGastly.Instance, // Pokemon Specie
				"Gastly", level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastly Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Gastly() : base(
			92,
			SpecieGastly.Instance, // Pokemon Specie
			Ghost.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}