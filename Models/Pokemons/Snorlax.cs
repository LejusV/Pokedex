using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Snorlax Specie to store common natural stats of all Snorlaxs
	#region SpecieSnorlax
	public class SpecieSnorlax : PokemonSpecie
	{
#nullable enable
		private static SpecieSnorlax? _instance = null;
#nullable restore
        public static SpecieSnorlax Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnorlax();
                }
                return _instance;
            }
        }

		#region SpecieSnorlax Builder
		public SpecieSnorlax() : base(
			"Snorlax",
			2.1,
			460.0,
			160, // HPs
			110, 65, // Attack & Defense
			65, 110, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Snorlax Pokemon Class
	#region Snorlax
	public class Snorlax : Pokemon
	{
		#region Snorlax Builders
		/// <summary>
		/// Snorlax Builder waiting for a Nickname & a Level
		/// </summary>
		public Snorlax(string nickname, int level)
		: base(
				143,
				SpecieSnorlax.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorlax Builder only waiting for a Level
		/// </summary>
		public Snorlax(int level)
		: base(
				143,
				SpecieSnorlax.Instance, // Pokemon Specie
				"Snorlax", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorlax Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Snorlax() : base(
			143,
			SpecieSnorlax.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}