using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Florges Specie to store common natural stats of all Florgess
	#region SpecieFlorges
	public class SpecieFlorges : PokemonSpecie
	{
#nullable enable
		private static SpecieFlorges? _instance = null;
#nullable restore
        public static SpecieFlorges Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlorges();
                }
                return _instance;
            }
        }

		#region SpecieFlorges Builder
		public SpecieFlorges() : base(
			"Florges",
			78, // HPs
			65, 68, // Attack & Defense
			112, 154, // Special Attack & Defense
			75			
		) {}
		#endregion
	}
	#endregion

	//Florges Pokemon Class
	#region Florges
	public class Florges : Pokemon
	{
		#region Florges Builders
		/// <summary>
		/// Florges Builder waiting for a Nickname & a Level
		/// </summary>
		public Florges(string nickname, int level)
		: base(
				671,
				SpecieFlorges.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Florges Builder only waiting for a Level
		/// </summary>
		public Florges(int level)
		: base(
				671,
				SpecieFlorges.Instance, // Pokemon Specie
				"Florges", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Florges Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Florges() : base(
			671,
			SpecieFlorges.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}