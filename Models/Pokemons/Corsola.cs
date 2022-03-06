using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Corsola Specie to store common natural stats of all Corsolas
	#region SpecieCorsola
	public class SpecieCorsola : PokemonSpecie
	{
#nullable enable
		private static SpecieCorsola? _instance = null;
#nullable restore
        public static SpecieCorsola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCorsola();
                }
                return _instance;
            }
        }

		#region SpecieCorsola Builder
		public SpecieCorsola() : base(
			"Corsola",
			0.6,
			5.0,
			65, // HPs
			55, 95, // Attack & Defense
			65, 95, // Special Attack & Defense
			35		
		)
		{}
		#endregion
	}
	#endregion

	//Corsola Pokemon Class
	#region Corsola
	public class Corsola : Pokemon
	{
		#region Corsola Builders
		/// <summary>
		/// Corsola Builder waiting for a Nickname & a Level
		/// </summary>
		public Corsola(string nickname, int level)
		: base(
				222,
				SpecieCorsola.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corsola Builder only waiting for a Level
		/// </summary>
		public Corsola(int level)
		: base(
				222,
				SpecieCorsola.Instance, // Pokemon Specie
				"Corsola", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corsola Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Corsola() : base(
			222,
			SpecieCorsola.Instance, // Pokemon Specie
			Water.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}