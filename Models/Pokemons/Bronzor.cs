using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bronzor Specie to store common natural stats of all Bronzors
	#region SpecieBronzor
	public class SpecieBronzor : PokemonSpecie
	{
#nullable enable
		private static SpecieBronzor? _instance = null;
#nullable restore
        public static SpecieBronzor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBronzor();
                }
                return _instance;
            }
        }

		#region SpecieBronzor Builder
		public SpecieBronzor() : base(
			"Bronzor",
			57, // HPs
			24, 86, // Attack & Defense
			24, 86, // Special Attack & Defense
			23			
		) {}
		#endregion
	}
	#endregion

	//Bronzor Pokemon Class
	#region Bronzor
	public class Bronzor : Pokemon
	{
		#region Bronzor Builders
		/// <summary>
		/// Bronzor Builder waiting for a Nickname & a Level
		/// </summary>
		public Bronzor(string nickname, int level)
		: base(
				436,
				SpecieBronzor.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzor Builder only waiting for a Level
		/// </summary>
		public Bronzor(int level)
		: base(
				436,
				SpecieBronzor.Instance, // Pokemon Specie
				"Bronzor", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzor Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Bronzor() : base(
			436,
			SpecieBronzor.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}