using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skuntank Specie to store common natural stats of all Skuntanks
	#region SpecieSkuntank
	public class SpecieSkuntank : PokemonSpecie
	{
#nullable enable
		private static SpecieSkuntank? _instance = null;
#nullable restore
        public static SpecieSkuntank Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkuntank();
                }
                return _instance;
            }
        }

		#region SpecieSkuntank Builder
		public SpecieSkuntank() : base(
			"Skuntank",
			103, // HPs
			93, 67, // Attack & Defense
			71, 61, // Special Attack & Defense
			84			
		) {}
		#endregion
	}
	#endregion

	//Skuntank Pokemon Class
	#region Skuntank
	public class Skuntank : Pokemon
	{
		#region Skuntank Builders
		/// <summary>
		/// Skuntank Builder waiting for a Nickname & a Level
		/// </summary>
		public Skuntank(string nickname, int level)
		: base(
				435,
				SpecieSkuntank.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skuntank Builder only waiting for a Level
		/// </summary>
		public Skuntank(int level)
		: base(
				435,
				SpecieSkuntank.Instance, // Pokemon Specie
				"Skuntank", level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skuntank Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Skuntank() : base(
			435,
			SpecieSkuntank.Instance, // Pokemon Specie
			Poison.Instance, Dark.Instance			
		) {}
		#endregion
	}
	#endregion
}