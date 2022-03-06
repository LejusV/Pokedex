using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Serperior Specie to store common natural stats of all Serperiors
	#region SpecieSerperior
	public class SpecieSerperior : PokemonSpecie
	{
#nullable enable
		private static SpecieSerperior? _instance = null;
#nullable restore
        public static SpecieSerperior Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSerperior();
                }
                return _instance;
            }
        }

		#region SpecieSerperior Builder
		public SpecieSerperior() : base(
			"Serperior",
			3.3,
			63.0,
			75, // HPs
			75, 95, // Attack & Defense
			75, 95, // Special Attack & Defense
			113		
		)
		{}
		#endregion
	}
	#endregion

	//Serperior Pokemon Class
	#region Serperior
	public class Serperior : Pokemon
	{
		#region Serperior Builders
		/// <summary>
		/// Serperior Builder waiting for a Nickname & a Level
		/// </summary>
		public Serperior(string nickname, int level)
		: base(
				497,
				SpecieSerperior.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Serperior Builder only waiting for a Level
		/// </summary>
		public Serperior(int level)
		: base(
				497,
				SpecieSerperior.Instance, // Pokemon Specie
				"Serperior", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Serperior Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Serperior() : base(
			497,
			SpecieSerperior.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}