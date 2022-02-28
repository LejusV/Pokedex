using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dewpider Specie to store common natural stats of all Dewpiders
	#region SpecieDewpider
	public class SpecieDewpider : PokemonSpecie
	{
#nullable enable
		private static SpecieDewpider? _instance = null;
#nullable restore
        public static SpecieDewpider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDewpider();
                }
                return _instance;
            }
        }

		#region SpecieDewpider Builder
		public SpecieDewpider() : base(
			"Dewpider",
			38, // HPs
			40, 52, // Attack & Defense
			40, 72, // Special Attack & Defense
			27			
		) {}
		#endregion
	}
	#endregion

	//Dewpider Pokemon Class
	#region Dewpider
	public class Dewpider : Pokemon
	{
		#region Dewpider Builders
		/// <summary>
		/// Dewpider Builder waiting for a Nickname & a Level
		/// </summary>
		public Dewpider(string nickname, int level)
		: base(
				751,
				SpecieDewpider.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewpider Builder only waiting for a Level
		/// </summary>
		public Dewpider(int level)
		: base(
				751,
				SpecieDewpider.Instance, // Pokemon Specie
				"Dewpider", level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewpider Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Dewpider() : base(
			751,
			SpecieDewpider.Instance, // Pokemon Specie
			Water.Instance, Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}