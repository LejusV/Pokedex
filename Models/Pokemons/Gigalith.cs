using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gigalith Specie to store common natural stats of all Gigaliths
	#region SpecieGigalith
	public class SpecieGigalith : PokemonSpecie
	{
#nullable enable
		private static SpecieGigalith? _instance = null;
#nullable restore
        public static SpecieGigalith Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGigalith();
                }
                return _instance;
            }
        }

		#region SpecieGigalith Builder
		public SpecieGigalith() : base(
			"Gigalith",
			1.7,
			260.0,
			85, // HPs
			135, 130, // Attack & Defense
			60, 80, // Special Attack & Defense
			25		
		)
		{}
		#endregion
	}
	#endregion

	//Gigalith Pokemon Class
	#region Gigalith
	public class Gigalith : Pokemon
	{
		#region Gigalith Builders
		/// <summary>
		/// Gigalith Builder waiting for a Nickname & a Level
		/// </summary>
		public Gigalith(string nickname, int level)
		: base(
				526,
				SpecieGigalith.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gigalith Builder only waiting for a Level
		/// </summary>
		public Gigalith(int level)
		: base(
				526,
				SpecieGigalith.Instance, // Pokemon Specie
				"Gigalith", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gigalith Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gigalith() : base(
			526,
			SpecieGigalith.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}