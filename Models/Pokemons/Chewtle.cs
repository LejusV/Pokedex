using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Chewtle Specie to store common natural stats of all Chewtles
	#region SpecieChewtle
	public class SpecieChewtle : PokemonSpecie
	{
#nullable enable
		private static SpecieChewtle? _instance = null;
#nullable restore
        public static SpecieChewtle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChewtle();
                }
                return _instance;
            }
        }

		#region SpecieChewtle Builder
		public SpecieChewtle() : base(
			"Chewtle",
			0.3,
			8.5,
			50, // HPs
			64, 50, // Attack & Defense
			38, 38, // Special Attack & Defense
			44		
		)
		{}
		#endregion
	}
	#endregion

	//Chewtle Pokemon Class
	#region Chewtle
	public class Chewtle : Pokemon
	{
		#region Chewtle Builders
		/// <summary>
		/// Chewtle Builder waiting for a Nickname & a Level
		/// </summary>
		public Chewtle(string nickname, int level)
		: base(
				833,
				SpecieChewtle.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chewtle Builder only waiting for a Level
		/// </summary>
		public Chewtle(int level)
		: base(
				833,
				SpecieChewtle.Instance, // Pokemon Specie
				"Chewtle", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chewtle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Chewtle() : base(
			833,
			SpecieChewtle.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}