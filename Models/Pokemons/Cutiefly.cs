using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cutiefly Specie to store common natural stats of all Cutieflys
	#region SpecieCutiefly
	public class SpecieCutiefly : PokemonSpecie
	{
#nullable enable
		private static SpecieCutiefly? _instance = null;
#nullable restore
        public static SpecieCutiefly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCutiefly();
                }
                return _instance;
            }
        }

		#region SpecieCutiefly Builder
		public SpecieCutiefly() : base(
			"Cutiefly",
			0.1,
			0.2,
			40, // HPs
			45, 40, // Attack & Defense
			55, 40, // Special Attack & Defense
			84		
		)
		{}
		#endregion
	}
	#endregion

	//Cutiefly Pokemon Class
	#region Cutiefly
	public class Cutiefly : Pokemon
	{
		#region Cutiefly Builders
		/// <summary>
		/// Cutiefly Builder waiting for a Nickname & a Level
		/// </summary>
		public Cutiefly(string nickname, int level)
		: base(
				742,
				SpecieCutiefly.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cutiefly Builder only waiting for a Level
		/// </summary>
		public Cutiefly(int level)
		: base(
				742,
				SpecieCutiefly.Instance, // Pokemon Specie
				"Cutiefly", level,
				Bug.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cutiefly Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cutiefly() : base(
			742,
			SpecieCutiefly.Instance, // Pokemon Specie
			Bug.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}