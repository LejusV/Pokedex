using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Glaceon Specie to store common natural stats of all Glaceons
	#region SpecieGlaceon
	public class SpecieGlaceon : PokemonSpecie
	{
#nullable enable
		private static SpecieGlaceon? _instance = null;
#nullable restore
        public static SpecieGlaceon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGlaceon();
                }
                return _instance;
            }
        }

		#region SpecieGlaceon Builder
		public SpecieGlaceon() : base(
			"Glaceon",
			0.8,
			25.9,
			65, // HPs
			60, 110, // Attack & Defense
			130, 95, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Glaceon Pokemon Class
	#region Glaceon
	public class Glaceon : Pokemon
	{
		#region Glaceon Builders
		/// <summary>
		/// Glaceon Builder waiting for a Nickname & a Level
		/// </summary>
		public Glaceon(string nickname, int level)
		: base(
				471,
				SpecieGlaceon.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glaceon Builder only waiting for a Level
		/// </summary>
		public Glaceon(int level)
		: base(
				471,
				SpecieGlaceon.Instance, // Pokemon Specie
				"Glaceon", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glaceon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Glaceon() : base(
			471,
			SpecieGlaceon.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}