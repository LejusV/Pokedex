using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hitmonlee Specie to store common natural stats of all Hitmonlees
	#region SpecieHitmonlee
	public class SpecieHitmonlee : PokemonSpecie
	{
#nullable enable
		private static SpecieHitmonlee? _instance = null;
#nullable restore
        public static SpecieHitmonlee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHitmonlee();
                }
                return _instance;
            }
        }

		#region SpecieHitmonlee Builder
		public SpecieHitmonlee() : base(
			"Hitmonlee",
			50, // HPs
			120, 53, // Attack & Defense
			35, 110, // Special Attack & Defense
			87			
		) {}
		#endregion
	}
	#endregion

	//Hitmonlee Pokemon Class
	#region Hitmonlee
	public class Hitmonlee : Pokemon
	{
		#region Hitmonlee Builders
		/// <summary>
		/// Hitmonlee Builder waiting for a Nickname & a Level
		/// </summary>
		public Hitmonlee(string nickname, int level)
		: base(
				106,
				SpecieHitmonlee.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonlee Builder only waiting for a Level
		/// </summary>
		public Hitmonlee(int level)
		: base(
				106,
				SpecieHitmonlee.Instance, // Pokemon Specie
				"Hitmonlee", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonlee Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Hitmonlee() : base(
			106,
			SpecieHitmonlee.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}