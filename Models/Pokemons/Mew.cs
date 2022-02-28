using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mew Specie to store common natural stats of all Mews
	#region SpecieMew
	public class SpecieMew : PokemonSpecie
	{
#nullable enable
		private static SpecieMew? _instance = null;
#nullable restore
        public static SpecieMew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMew();
                }
                return _instance;
            }
        }

		#region SpecieMew Builder
		public SpecieMew() : base(
			"Mew",
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100			
		) {}
		#endregion
	}
	#endregion

	//Mew Pokemon Class
	#region Mew
	public class Mew : Pokemon
	{
		#region Mew Builders
		/// <summary>
		/// Mew Builder waiting for a Nickname & a Level
		/// </summary>
		public Mew(string nickname, int level)
		: base(
				151,
				SpecieMew.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mew Builder only waiting for a Level
		/// </summary>
		public Mew(int level)
		: base(
				151,
				SpecieMew.Instance, // Pokemon Specie
				"Mew", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mew Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Mew() : base(
			151,
			SpecieMew.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}