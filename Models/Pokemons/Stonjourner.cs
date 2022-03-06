using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Stonjourner Specie to store common natural stats of all Stonjourners
	#region SpecieStonjourner
	public class SpecieStonjourner : PokemonSpecie
	{
#nullable enable
		private static SpecieStonjourner? _instance = null;
#nullable restore
        public static SpecieStonjourner Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStonjourner();
                }
                return _instance;
            }
        }

		#region SpecieStonjourner Builder
		public SpecieStonjourner() : base(
			"Stonjourner",
			2.5,
			520.0,
			100, // HPs
			125, 135, // Attack & Defense
			20, 20, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Stonjourner Pokemon Class
	#region Stonjourner
	public class Stonjourner : Pokemon
	{
		#region Stonjourner Builders
		/// <summary>
		/// Stonjourner Builder waiting for a Nickname & a Level
		/// </summary>
		public Stonjourner(string nickname, int level)
		: base(
				874,
				SpecieStonjourner.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stonjourner Builder only waiting for a Level
		/// </summary>
		public Stonjourner(int level)
		: base(
				874,
				SpecieStonjourner.Instance, // Pokemon Specie
				"Stonjourner", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stonjourner Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Stonjourner() : base(
			874,
			SpecieStonjourner.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}