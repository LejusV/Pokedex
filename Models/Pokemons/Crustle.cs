using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Crustle Specie to store common natural stats of all Crustles
	#region SpecieCrustle
	public class SpecieCrustle : PokemonSpecie
	{
#nullable enable
		private static SpecieCrustle? _instance = null;
#nullable restore
        public static SpecieCrustle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCrustle();
                }
                return _instance;
            }
        }

		#region SpecieCrustle Builder
		public SpecieCrustle() : base(
			"Crustle",
			1.4,
			200.0,
			70, // HPs
			105, 125, // Attack & Defense
			65, 75, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Crustle Pokemon Class
	#region Crustle
	public class Crustle : Pokemon
	{
		#region Crustle Builders
		/// <summary>
		/// Crustle Builder waiting for a Nickname & a Level
		/// </summary>
		public Crustle(string nickname, int level)
		: base(
				558,
				SpecieCrustle.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crustle Builder only waiting for a Level
		/// </summary>
		public Crustle(int level)
		: base(
				558,
				SpecieCrustle.Instance, // Pokemon Specie
				"Crustle", level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crustle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Crustle() : base(
			558,
			SpecieCrustle.Instance, // Pokemon Specie
			Bug.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}