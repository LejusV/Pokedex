using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Druddigon Specie to store common natural stats of all Druddigons
	#region SpecieDruddigon
	public class SpecieDruddigon : PokemonSpecie
	{
#nullable enable
		private static SpecieDruddigon? _instance = null;
#nullable restore
        public static SpecieDruddigon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDruddigon();
                }
                return _instance;
            }
        }

		#region SpecieDruddigon Builder
		public SpecieDruddigon() : base(
			"Druddigon",
			77, // HPs
			120, 90, // Attack & Defense
			60, 90, // Special Attack & Defense
			48			
		) {}
		#endregion
	}
	#endregion

	//Druddigon Pokemon Class
	#region Druddigon
	public class Druddigon : Pokemon
	{
		#region Druddigon Builders
		/// <summary>
		/// Druddigon Builder waiting for a Nickname & a Level
		/// </summary>
		public Druddigon(string nickname, int level)
		: base(
				621,
				SpecieDruddigon.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Druddigon Builder only waiting for a Level
		/// </summary>
		public Druddigon(int level)
		: base(
				621,
				SpecieDruddigon.Instance, // Pokemon Specie
				"Druddigon", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Druddigon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Druddigon() : base(
			621,
			SpecieDruddigon.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		#endregion
	}
	#endregion
}