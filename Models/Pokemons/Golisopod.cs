using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Golisopod Specie to store common natural stats of all Golisopods
	#region SpecieGolisopod
	public class SpecieGolisopod : PokemonSpecie
	{
#nullable enable
		private static SpecieGolisopod? _instance = null;
#nullable restore
        public static SpecieGolisopod Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolisopod();
                }
                return _instance;
            }
        }

		#region SpecieGolisopod Builder
		public SpecieGolisopod() : base(
			"Golisopod",
			75, // HPs
			125, 140, // Attack & Defense
			60, 90, // Special Attack & Defense
			40			
		) {}
		#endregion
	}
	#endregion

	//Golisopod Pokemon Class
	#region Golisopod
	public class Golisopod : Pokemon
	{
		#region Golisopod Builders
		/// <summary>
		/// Golisopod Builder waiting for a Nickname & a Level
		/// </summary>
		public Golisopod(string nickname, int level)
		: base(
				768,
				SpecieGolisopod.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golisopod Builder only waiting for a Level
		/// </summary>
		public Golisopod(int level)
		: base(
				768,
				SpecieGolisopod.Instance, // Pokemon Specie
				"Golisopod", level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golisopod Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Golisopod() : base(
			768,
			SpecieGolisopod.Instance, // Pokemon Specie
			Bug.Instance, Water.Instance			
		) {}
		#endregion
	}
	#endregion
}