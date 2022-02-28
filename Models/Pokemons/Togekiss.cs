using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Togekiss Specie to store common natural stats of all Togekisss
	#region SpecieTogekiss
	public class SpecieTogekiss : PokemonSpecie
	{
#nullable enable
		private static SpecieTogekiss? _instance = null;
#nullable restore
        public static SpecieTogekiss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTogekiss();
                }
                return _instance;
            }
        }

		#region SpecieTogekiss Builder
		public SpecieTogekiss() : base(
			"Togekiss",
			85, // HPs
			50, 95, // Attack & Defense
			120, 115, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Togekiss Pokemon Class
	#region Togekiss
	public class Togekiss : Pokemon
	{
		#region Togekiss Builders
		/// <summary>
		/// Togekiss Builder waiting for a Nickname & a Level
		/// </summary>
		public Togekiss(string nickname, int level)
		: base(
				468,
				SpecieTogekiss.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togekiss Builder only waiting for a Level
		/// </summary>
		public Togekiss(int level)
		: base(
				468,
				SpecieTogekiss.Instance, // Pokemon Specie
				"Togekiss", level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togekiss Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Togekiss() : base(
			468,
			SpecieTogekiss.Instance, // Pokemon Specie
			Fairy.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}