using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Charmander Specie to store common natural stats of all Charmanders
	#region SpecieCharmander
	public class SpecieCharmander : PokemonSpecie
	{
#nullable enable
		private static SpecieCharmander? _instance = null;
#nullable restore
        public static SpecieCharmander Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCharmander();
                }
                return _instance;
            }
        }

		#region SpecieCharmander Builder
		public SpecieCharmander() : base(
			"Charmander",
			39, // HPs
			52, 43, // Attack & Defense
			60, 50, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Charmander Pokemon Class
	#region Charmander
	public class Charmander : Pokemon
	{
		#region Charmander Builders
		/// <summary>
		/// Charmander Builder waiting for a Nickname & a Level
		/// </summary>
		public Charmander(string nickname, int level)
		: base(
				4,
				SpecieCharmander.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmander Builder only waiting for a Level
		/// </summary>
		public Charmander(int level)
		: base(
				4,
				SpecieCharmander.Instance, // Pokemon Specie
				"Charmander", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmander Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Charmander() : base(
			4,
			SpecieCharmander.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}