using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Glameow Specie to store common natural stats of all Glameows
	#region SpecieGlameow
	public class SpecieGlameow : PokemonSpecie
	{
#nullable enable
		private static SpecieGlameow? _instance = null;
#nullable restore
        public static SpecieGlameow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGlameow();
                }
                return _instance;
            }
        }

		#region SpecieGlameow Builder
		public SpecieGlameow() : base(
			"Glameow",
			0.5,
			3.9,
			49, // HPs
			55, 42, // Attack & Defense
			42, 37, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Glameow Pokemon Class
	#region Glameow
	public class Glameow : Pokemon
	{
		#region Glameow Builders
		/// <summary>
		/// Glameow Builder waiting for a Nickname & a Level
		/// </summary>
		public Glameow(string nickname, int level)
		: base(
				431,
				SpecieGlameow.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glameow Builder only waiting for a Level
		/// </summary>
		public Glameow(int level)
		: base(
				431,
				SpecieGlameow.Instance, // Pokemon Specie
				"Glameow", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glameow Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Glameow() : base(
			431,
			SpecieGlameow.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}