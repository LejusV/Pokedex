using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Swirlix Specie to store common natural stats of all Swirlixs
	#region SpecieSwirlix
	public class SpecieSwirlix : PokemonSpecie
	{
#nullable enable
		private static SpecieSwirlix? _instance = null;
#nullable restore
        public static SpecieSwirlix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwirlix();
                }
                return _instance;
            }
        }

		#region SpecieSwirlix Builder
		public SpecieSwirlix() : base(
			"Swirlix",
			62, // HPs
			48, 66, // Attack & Defense
			59, 57, // Special Attack & Defense
			49			
		) {}
		#endregion
	}
	#endregion

	//Swirlix Pokemon Class
	#region Swirlix
	public class Swirlix : Pokemon
	{
		#region Swirlix Builders
		/// <summary>
		/// Swirlix Builder waiting for a Nickname & a Level
		/// </summary>
		public Swirlix(string nickname, int level)
		: base(
				684,
				SpecieSwirlix.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swirlix Builder only waiting for a Level
		/// </summary>
		public Swirlix(int level)
		: base(
				684,
				SpecieSwirlix.Instance, // Pokemon Specie
				"Swirlix", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swirlix Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Swirlix() : base(
			684,
			SpecieSwirlix.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}