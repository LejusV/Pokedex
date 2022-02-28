using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shedinja Specie to store common natural stats of all Shedinjas
	#region SpecieShedinja
	public class SpecieShedinja : PokemonSpecie
	{
#nullable enable
		private static SpecieShedinja? _instance = null;
#nullable restore
        public static SpecieShedinja Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShedinja();
                }
                return _instance;
            }
        }

		#region SpecieShedinja Builder
		public SpecieShedinja() : base(
			"Shedinja",
			1, // HPs
			90, 45, // Attack & Defense
			30, 30, // Special Attack & Defense
			40			
		) {}
		#endregion
	}
	#endregion

	//Shedinja Pokemon Class
	#region Shedinja
	public class Shedinja : Pokemon
	{
		#region Shedinja Builders
		/// <summary>
		/// Shedinja Builder waiting for a Nickname & a Level
		/// </summary>
		public Shedinja(string nickname, int level)
		: base(
				292,
				SpecieShedinja.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shedinja Builder only waiting for a Level
		/// </summary>
		public Shedinja(int level)
		: base(
				292,
				SpecieShedinja.Instance, // Pokemon Specie
				"Shedinja", level,
				Bug.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shedinja Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Shedinja() : base(
			292,
			SpecieShedinja.Instance, // Pokemon Specie
			Bug.Instance, Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}