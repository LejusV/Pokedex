using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sableye Specie to store common natural stats of all Sableyes
	#region SpecieSableye
	public class SpecieSableye : PokemonSpecie
	{
#nullable enable
		private static SpecieSableye? _instance = null;
#nullable restore
        public static SpecieSableye Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSableye();
                }
                return _instance;
            }
        }

		#region SpecieSableye Builder
		public SpecieSableye() : base(
			"Sableye",
			50, // HPs
			75, 75, // Attack & Defense
			65, 65, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Sableye Pokemon Class
	#region Sableye
	public class Sableye : Pokemon
	{
		#region Sableye Builders
		/// <summary>
		/// Sableye Builder waiting for a Nickname & a Level
		/// </summary>
		public Sableye(string nickname, int level)
		: base(
				302,
				SpecieSableye.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sableye Builder only waiting for a Level
		/// </summary>
		public Sableye(int level)
		: base(
				302,
				SpecieSableye.Instance, // Pokemon Specie
				"Sableye", level,
				Dark.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sableye Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Sableye() : base(
			302,
			SpecieSableye.Instance, // Pokemon Specie
			Dark.Instance, Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}