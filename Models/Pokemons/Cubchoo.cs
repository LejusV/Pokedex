using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cubchoo Specie to store common natural stats of all Cubchoos
	#region SpecieCubchoo
	public class SpecieCubchoo : PokemonSpecie
	{
#nullable enable
		private static SpecieCubchoo? _instance = null;
#nullable restore
        public static SpecieCubchoo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCubchoo();
                }
                return _instance;
            }
        }

		#region SpecieCubchoo Builder
		public SpecieCubchoo() : base(
			"Cubchoo",
			0.5,
			8.5,
			55, // HPs
			70, 40, // Attack & Defense
			60, 40, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Cubchoo Pokemon Class
	#region Cubchoo
	public class Cubchoo : Pokemon
	{
		#region Cubchoo Builders
		/// <summary>
		/// Cubchoo Builder waiting for a Nickname & a Level
		/// </summary>
		public Cubchoo(string nickname, int level)
		: base(
				613,
				SpecieCubchoo.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubchoo Builder only waiting for a Level
		/// </summary>
		public Cubchoo(int level)
		: base(
				613,
				SpecieCubchoo.Instance, // Pokemon Specie
				"Cubchoo", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubchoo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cubchoo() : base(
			613,
			SpecieCubchoo.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}