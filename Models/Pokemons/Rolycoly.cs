using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rolycoly Specie to store common natural stats of all Rolycolys
	#region SpecieRolycoly
	public class SpecieRolycoly : PokemonSpecie
	{
#nullable enable
		private static SpecieRolycoly? _instance = null;
#nullable restore
        public static SpecieRolycoly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRolycoly();
                }
                return _instance;
            }
        }

		#region SpecieRolycoly Builder
		public SpecieRolycoly() : base(
			"Rolycoly",
			30, // HPs
			40, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Rolycoly Pokemon Class
	#region Rolycoly
	public class Rolycoly : Pokemon
	{
		#region Rolycoly Builders
		/// <summary>
		/// Rolycoly Builder waiting for a Nickname & a Level
		/// </summary>
		public Rolycoly(string nickname, int level)
		: base(
				837,
				SpecieRolycoly.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rolycoly Builder only waiting for a Level
		/// </summary>
		public Rolycoly(int level)
		: base(
				837,
				SpecieRolycoly.Instance, // Pokemon Specie
				"Rolycoly", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rolycoly Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Rolycoly() : base(
			837,
			SpecieRolycoly.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		#endregion
	}
	#endregion
}