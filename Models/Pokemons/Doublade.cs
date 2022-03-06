using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Doublade Specie to store common natural stats of all Doublades
	#region SpecieDoublade
	public class SpecieDoublade : PokemonSpecie
	{
#nullable enable
		private static SpecieDoublade? _instance = null;
#nullable restore
        public static SpecieDoublade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDoublade();
                }
                return _instance;
            }
        }

		#region SpecieDoublade Builder
		public SpecieDoublade() : base(
			"Doublade",
			0.8,
			4.5,
			59, // HPs
			110, 150, // Attack & Defense
			45, 49, // Special Attack & Defense
			35		
		)
		{}
		#endregion
	}
	#endregion

	//Doublade Pokemon Class
	#region Doublade
	public class Doublade : Pokemon
	{
		#region Doublade Builders
		/// <summary>
		/// Doublade Builder waiting for a Nickname & a Level
		/// </summary>
		public Doublade(string nickname, int level)
		: base(
				680,
				SpecieDoublade.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doublade Builder only waiting for a Level
		/// </summary>
		public Doublade(int level)
		: base(
				680,
				SpecieDoublade.Instance, // Pokemon Specie
				"Doublade", level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doublade Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Doublade() : base(
			680,
			SpecieDoublade.Instance, // Pokemon Specie
			Steel.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}