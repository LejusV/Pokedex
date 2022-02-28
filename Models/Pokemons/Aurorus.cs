using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Aurorus Specie to store common natural stats of all Auroruss
	#region SpecieAurorus
	public class SpecieAurorus : PokemonSpecie
	{
#nullable enable
		private static SpecieAurorus? _instance = null;
#nullable restore
        public static SpecieAurorus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAurorus();
                }
                return _instance;
            }
        }

		#region SpecieAurorus Builder
		public SpecieAurorus() : base(
			"Aurorus",
			123, // HPs
			77, 72, // Attack & Defense
			99, 92, // Special Attack & Defense
			58			
		) {}
		#endregion
	}
	#endregion

	//Aurorus Pokemon Class
	#region Aurorus
	public class Aurorus : Pokemon
	{
		#region Aurorus Builders
		/// <summary>
		/// Aurorus Builder waiting for a Nickname & a Level
		/// </summary>
		public Aurorus(string nickname, int level)
		: base(
				699,
				SpecieAurorus.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aurorus Builder only waiting for a Level
		/// </summary>
		public Aurorus(int level)
		: base(
				699,
				SpecieAurorus.Instance, // Pokemon Specie
				"Aurorus", level,
				Rock.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aurorus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Aurorus() : base(
			699,
			SpecieAurorus.Instance, // Pokemon Specie
			Rock.Instance, Ice.Instance			
		) {}
		#endregion
	}
	#endregion
}