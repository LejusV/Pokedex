using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Xurkitree Specie to store common natural stats of all Xurkitrees
	#region SpecieXurkitree
	public class SpecieXurkitree : PokemonSpecie
	{
#nullable enable
		private static SpecieXurkitree? _instance = null;
#nullable restore
        public static SpecieXurkitree Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieXurkitree();
                }
                return _instance;
            }
        }

		#region SpecieXurkitree Builder
		public SpecieXurkitree() : base(
			"Xurkitree",
			83, // HPs
			89, 71, // Attack & Defense
			173, 71, // Special Attack & Defense
			83			
		) {}
		#endregion
	}
	#endregion

	//Xurkitree Pokemon Class
	#region Xurkitree
	public class Xurkitree : Pokemon
	{
		#region Xurkitree Builders
		/// <summary>
		/// Xurkitree Builder waiting for a Nickname & a Level
		/// </summary>
		public Xurkitree(string nickname, int level)
		: base(
				796,
				SpecieXurkitree.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xurkitree Builder only waiting for a Level
		/// </summary>
		public Xurkitree(int level)
		: base(
				796,
				SpecieXurkitree.Instance, // Pokemon Specie
				"Xurkitree", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xurkitree Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Xurkitree() : base(
			796,
			SpecieXurkitree.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}