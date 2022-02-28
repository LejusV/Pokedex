using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Deerling Specie to store common natural stats of all Deerlings
	#region SpecieDeerling
	public class SpecieDeerling : PokemonSpecie
	{
#nullable enable
		private static SpecieDeerling? _instance = null;
#nullable restore
        public static SpecieDeerling Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDeerling();
                }
                return _instance;
            }
        }

		#region SpecieDeerling Builder
		public SpecieDeerling() : base(
			"Deerling",
			60, // HPs
			60, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			75			
		) {}
		#endregion
	}
	#endregion

	//Deerling Pokemon Class
	#region Deerling
	public class Deerling : Pokemon
	{
		#region Deerling Builders
		/// <summary>
		/// Deerling Builder waiting for a Nickname & a Level
		/// </summary>
		public Deerling(string nickname, int level)
		: base(
				585,
				SpecieDeerling.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deerling Builder only waiting for a Level
		/// </summary>
		public Deerling(int level)
		: base(
				585,
				SpecieDeerling.Instance, // Pokemon Specie
				"Deerling", level,
				Normal.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deerling Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Deerling() : base(
			585,
			SpecieDeerling.Instance, // Pokemon Specie
			Normal.Instance, Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}