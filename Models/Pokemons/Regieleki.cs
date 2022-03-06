using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Regieleki Specie to store common natural stats of all Regielekis
	#region SpecieRegieleki
	public class SpecieRegieleki : PokemonSpecie
	{
#nullable enable
		private static SpecieRegieleki? _instance = null;
#nullable restore
        public static SpecieRegieleki Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegieleki();
                }
                return _instance;
            }
        }

		#region SpecieRegieleki Builder
		public SpecieRegieleki() : base(
			"Regieleki",
			1.2,
			145.0,
			80, // HPs
			100, 50, // Attack & Defense
			100, 50, // Special Attack & Defense
			200		
		)
		{}
		#endregion
	}
	#endregion

	//Regieleki Pokemon Class
	#region Regieleki
	public class Regieleki : Pokemon
	{
		#region Regieleki Builders
		/// <summary>
		/// Regieleki Builder waiting for a Nickname & a Level
		/// </summary>
		public Regieleki(string nickname, int level)
		: base(
				894,
				SpecieRegieleki.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regieleki Builder only waiting for a Level
		/// </summary>
		public Regieleki(int level)
		: base(
				894,
				SpecieRegieleki.Instance, // Pokemon Specie
				"Regieleki", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regieleki Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Regieleki() : base(
			894,
			SpecieRegieleki.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}