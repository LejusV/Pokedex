using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wingull Specie to store common natural stats of all Wingulls
	#region SpecieWingull
	public class SpecieWingull : PokemonSpecie
	{
#nullable enable
		private static SpecieWingull? _instance = null;
#nullable restore
        public static SpecieWingull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWingull();
                }
                return _instance;
            }
        }

		#region SpecieWingull Builder
		public SpecieWingull() : base(
			"Wingull",
			40, // HPs
			30, 30, // Attack & Defense
			55, 30, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Wingull Pokemon Class
	#region Wingull
	public class Wingull : Pokemon
	{
		#region Wingull Builders
		/// <summary>
		/// Wingull Builder waiting for a Nickname & a Level
		/// </summary>
		public Wingull(string nickname, int level)
		: base(
				278,
				SpecieWingull.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wingull Builder only waiting for a Level
		/// </summary>
		public Wingull(int level)
		: base(
				278,
				SpecieWingull.Instance, // Pokemon Specie
				"Wingull", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wingull Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Wingull() : base(
			278,
			SpecieWingull.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}