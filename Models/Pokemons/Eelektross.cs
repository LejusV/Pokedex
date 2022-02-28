using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Eelektross Specie to store common natural stats of all Eelektrosss
	#region SpecieEelektross
	public class SpecieEelektross : PokemonSpecie
	{
#nullable enable
		private static SpecieEelektross? _instance = null;
#nullable restore
        public static SpecieEelektross Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEelektross();
                }
                return _instance;
            }
        }

		#region SpecieEelektross Builder
		public SpecieEelektross() : base(
			"Eelektross",
			85, // HPs
			115, 80, // Attack & Defense
			105, 80, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Eelektross Pokemon Class
	#region Eelektross
	public class Eelektross : Pokemon
	{
		#region Eelektross Builders
		/// <summary>
		/// Eelektross Builder waiting for a Nickname & a Level
		/// </summary>
		public Eelektross(string nickname, int level)
		: base(
				604,
				SpecieEelektross.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektross Builder only waiting for a Level
		/// </summary>
		public Eelektross(int level)
		: base(
				604,
				SpecieEelektross.Instance, // Pokemon Specie
				"Eelektross", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektross Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Eelektross() : base(
			604,
			SpecieEelektross.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}