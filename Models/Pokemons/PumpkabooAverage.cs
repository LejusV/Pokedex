using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pumpkaboo-Average Specie to store common natural stats of all Pumpkaboo-Averages
	#region SpeciePumpkaboo-Average
	public class SpeciePumpkabooAverage : PokemonSpecie
	{
#nullable enable
		private static SpeciePumpkabooAverage? _instance = null;
#nullable restore
        public static SpeciePumpkabooAverage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePumpkabooAverage();
                }
                return _instance;
            }
        }

		#region SpeciePumpkaboo-Average Builder
		public SpeciePumpkabooAverage() : base(
			"Pumpkaboo-Average",
			49, // HPs
			66, 70, // Attack & Defense
			44, 55, // Special Attack & Defense
			51			
		) {}
		#endregion
	}
	#endregion

	//Pumpkaboo-Average Pokemon Class
	#region Pumpkaboo-Average
	public class PumpkabooAverage : Pokemon
	{
		#region Pumpkaboo-Average Builders
		/// <summary>
		/// Pumpkaboo-Average Builder waiting for a Nickname & a Level
		/// </summary>
		public PumpkabooAverage(string nickname, int level)
		: base(
				710,
				SpeciePumpkabooAverage.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pumpkaboo-Average Builder only waiting for a Level
		/// </summary>
		public PumpkabooAverage(int level)
		: base(
				710,
				SpeciePumpkabooAverage.Instance, // Pokemon Specie
				"Pumpkaboo-Average", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pumpkaboo-Average Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public PumpkabooAverage() : base(
			710,
			SpeciePumpkabooAverage.Instance, // Pokemon Specie
			Ghost.Instance, Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}