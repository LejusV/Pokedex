using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Houndour Specie to store common natural stats of all Houndours
	#region SpecieHoundour
	public class SpecieHoundour : PokemonSpecie
	{
#nullable enable
		private static SpecieHoundour? _instance = null;
#nullable restore
        public static SpecieHoundour Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoundour();
                }
                return _instance;
            }
        }

		#region SpecieHoundour Builder
		public SpecieHoundour() : base(
			"Houndour",
			0.6,
			10.8,
			45, // HPs
			60, 30, // Attack & Defense
			80, 50, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Houndour Pokemon Class
	#region Houndour
	public class Houndour : Pokemon
	{
		#region Houndour Builders
		/// <summary>
		/// Houndour Builder waiting for a Nickname & a Level
		/// </summary>
		public Houndour(string nickname, int level)
		: base(
				228,
				SpecieHoundour.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndour Builder only waiting for a Level
		/// </summary>
		public Houndour(int level)
		: base(
				228,
				SpecieHoundour.Instance, // Pokemon Specie
				"Houndour", level,
				Dark.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndour Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Houndour() : base(
			228,
			SpecieHoundour.Instance, // Pokemon Specie
			Dark.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}