using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lunala Specie to store common natural stats of all Lunalas
	#region SpecieLunala
	public class SpecieLunala : PokemonSpecie
	{
#nullable enable
		private static SpecieLunala? _instance = null;
#nullable restore
        public static SpecieLunala Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLunala();
                }
                return _instance;
            }
        }

		#region SpecieLunala Builder
		public SpecieLunala() : base(
			"Lunala",
			137, // HPs
			113, 89, // Attack & Defense
			137, 107, // Special Attack & Defense
			97			
		) {}
		#endregion
	}
	#endregion

	//Lunala Pokemon Class
	#region Lunala
	public class Lunala : Pokemon
	{
		#region Lunala Builders
		/// <summary>
		/// Lunala Builder waiting for a Nickname & a Level
		/// </summary>
		public Lunala(string nickname, int level)
		: base(
				792,
				SpecieLunala.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunala Builder only waiting for a Level
		/// </summary>
		public Lunala(int level)
		: base(
				792,
				SpecieLunala.Instance, // Pokemon Specie
				"Lunala", level,
				Psychic.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunala Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Lunala() : base(
			792,
			SpecieLunala.Instance, // Pokemon Specie
			Psychic.Instance, Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}