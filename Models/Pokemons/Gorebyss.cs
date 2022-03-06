using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gorebyss Specie to store common natural stats of all Gorebysss
	#region SpecieGorebyss
	public class SpecieGorebyss : PokemonSpecie
	{
#nullable enable
		private static SpecieGorebyss? _instance = null;
#nullable restore
        public static SpecieGorebyss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGorebyss();
                }
                return _instance;
            }
        }

		#region SpecieGorebyss Builder
		public SpecieGorebyss() : base(
			"Gorebyss",
			1.8,
			22.6,
			55, // HPs
			84, 105, // Attack & Defense
			114, 75, // Special Attack & Defense
			52		
		)
		{}
		#endregion
	}
	#endregion

	//Gorebyss Pokemon Class
	#region Gorebyss
	public class Gorebyss : Pokemon
	{
		#region Gorebyss Builders
		/// <summary>
		/// Gorebyss Builder waiting for a Nickname & a Level
		/// </summary>
		public Gorebyss(string nickname, int level)
		: base(
				368,
				SpecieGorebyss.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gorebyss Builder only waiting for a Level
		/// </summary>
		public Gorebyss(int level)
		: base(
				368,
				SpecieGorebyss.Instance, // Pokemon Specie
				"Gorebyss", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gorebyss Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gorebyss() : base(
			368,
			SpecieGorebyss.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}