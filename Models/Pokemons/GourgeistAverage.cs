using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gourgeist-Average Specie to store common natural stats of all Gourgeist-Averages
	#region SpecieGourgeist-Average
	public class SpecieGourgeistAverage : PokemonSpecie
	{
#nullable enable
		private static SpecieGourgeistAverage? _instance = null;
#nullable restore
        public static SpecieGourgeistAverage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGourgeistAverage();
                }
                return _instance;
            }
        }

		#region SpecieGourgeist-Average Builder
		public SpecieGourgeistAverage() : base(
			"Gourgeist-Average",
			0.9,
			12.5,
			65, // HPs
			90, 122, // Attack & Defense
			58, 75, // Special Attack & Defense
			84		
		)
		{}
		#endregion
	}
	#endregion

	//Gourgeist-Average Pokemon Class
	#region Gourgeist-Average
	public class GourgeistAverage : Pokemon
	{
		#region Gourgeist-Average Builders
		/// <summary>
		/// Gourgeist-Average Builder waiting for a Nickname & a Level
		/// </summary>
		public GourgeistAverage(string nickname, int level)
		: base(
				711,
				SpecieGourgeistAverage.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gourgeist-Average Builder only waiting for a Level
		/// </summary>
		public GourgeistAverage(int level)
		: base(
				711,
				SpecieGourgeistAverage.Instance, // Pokemon Specie
				"Gourgeist-Average", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gourgeist-Average Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public GourgeistAverage() : base(
			711,
			SpecieGourgeistAverage.Instance, // Pokemon Specie
			Ghost.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}