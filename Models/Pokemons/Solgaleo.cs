using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Solgaleo Specie to store common natural stats of all Solgaleos
	#region SpecieSolgaleo
	public class SpecieSolgaleo : PokemonSpecie
	{
#nullable enable
		private static SpecieSolgaleo? _instance = null;
#nullable restore
        public static SpecieSolgaleo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSolgaleo();
                }
                return _instance;
            }
        }

		#region SpecieSolgaleo Builder
		public SpecieSolgaleo() : base(
			"Solgaleo",
			137, // HPs
			137, 107, // Attack & Defense
			113, 89, // Special Attack & Defense
			97			
		) {}
		#endregion
	}
	#endregion

	//Solgaleo Pokemon Class
	#region Solgaleo
	public class Solgaleo : Pokemon
	{
		#region Solgaleo Builders
		/// <summary>
		/// Solgaleo Builder waiting for a Nickname & a Level
		/// </summary>
		public Solgaleo(string nickname, int level)
		: base(
				791,
				SpecieSolgaleo.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solgaleo Builder only waiting for a Level
		/// </summary>
		public Solgaleo(int level)
		: base(
				791,
				SpecieSolgaleo.Instance, // Pokemon Specie
				"Solgaleo", level,
				Psychic.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solgaleo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Solgaleo() : base(
			791,
			SpecieSolgaleo.Instance, // Pokemon Specie
			Psychic.Instance, Steel.Instance			
		) {}
		#endregion
	}
	#endregion
}