using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tympole Specie to store common natural stats of all Tympoles
	#region SpecieTympole
	public class SpecieTympole : PokemonSpecie
	{
#nullable enable
		private static SpecieTympole? _instance = null;
#nullable restore
        public static SpecieTympole Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTympole();
                }
                return _instance;
            }
        }

		#region SpecieTympole Builder
		public SpecieTympole() : base(
			"Tympole",
			50, // HPs
			50, 40, // Attack & Defense
			50, 40, // Special Attack & Defense
			64			
		) {}
		#endregion
	}
	#endregion

	//Tympole Pokemon Class
	#region Tympole
	public class Tympole : Pokemon
	{
		#region Tympole Builders
		/// <summary>
		/// Tympole Builder waiting for a Nickname & a Level
		/// </summary>
		public Tympole(string nickname, int level)
		: base(
				535,
				SpecieTympole.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tympole Builder only waiting for a Level
		/// </summary>
		public Tympole(int level)
		: base(
				535,
				SpecieTympole.Instance, // Pokemon Specie
				"Tympole", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tympole Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Tympole() : base(
			535,
			SpecieTympole.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}