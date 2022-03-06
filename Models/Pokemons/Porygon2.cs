using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Porygon2 Specie to store common natural stats of all Porygon2s
	#region SpeciePorygon2
	public class SpeciePorygon2 : PokemonSpecie
	{
#nullable enable
		private static SpeciePorygon2? _instance = null;
#nullable restore
        public static SpeciePorygon2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePorygon2();
                }
                return _instance;
            }
        }

		#region SpeciePorygon2 Builder
		public SpeciePorygon2() : base(
			"Porygon2",
			0.6,
			32.5,
			85, // HPs
			80, 90, // Attack & Defense
			105, 95, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Porygon2 Pokemon Class
	#region Porygon2
	public class Porygon2 : Pokemon
	{
		#region Porygon2 Builders
		/// <summary>
		/// Porygon2 Builder waiting for a Nickname & a Level
		/// </summary>
		public Porygon2(string nickname, int level)
		: base(
				233,
				SpeciePorygon2.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon2 Builder only waiting for a Level
		/// </summary>
		public Porygon2(int level)
		: base(
				233,
				SpeciePorygon2.Instance, // Pokemon Specie
				"Porygon2", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon2 Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Porygon2() : base(
			233,
			SpeciePorygon2.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}