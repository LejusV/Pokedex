using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Machop Specie to store common natural stats of all Machops
	#region SpecieMachop
	public class SpecieMachop : PokemonSpecie
	{
#nullable enable
		private static SpecieMachop? _instance = null;
#nullable restore
        public static SpecieMachop Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMachop();
                }
                return _instance;
            }
        }

		#region SpecieMachop Builder
		public SpecieMachop() : base(
			"Machop",
			70, // HPs
			80, 50, // Attack & Defense
			35, 35, // Special Attack & Defense
			35			
		) {}
		#endregion
	}
	#endregion

	//Machop Pokemon Class
	#region Machop
	public class Machop : Pokemon
	{
		#region Machop Builders
		/// <summary>
		/// Machop Builder waiting for a Nickname & a Level
		/// </summary>
		public Machop(string nickname, int level)
		: base(
				66,
				SpecieMachop.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machop Builder only waiting for a Level
		/// </summary>
		public Machop(int level)
		: base(
				66,
				SpecieMachop.Instance, // Pokemon Specie
				"Machop", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machop Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Machop() : base(
			66,
			SpecieMachop.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}