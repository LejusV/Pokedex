using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drapion Specie to store common natural stats of all Drapions
	#region SpecieDrapion
	public class SpecieDrapion : PokemonSpecie
	{
#nullable enable
		private static SpecieDrapion? _instance = null;
#nullable restore
        public static SpecieDrapion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrapion();
                }
                return _instance;
            }
        }

		#region SpecieDrapion Builder
		public SpecieDrapion() : base(
			"Drapion",
			70, // HPs
			90, 110, // Attack & Defense
			60, 75, // Special Attack & Defense
			95			
		) {}
		#endregion
	}
	#endregion

	//Drapion Pokemon Class
	#region Drapion
	public class Drapion : Pokemon
	{
		#region Drapion Builders
		/// <summary>
		/// Drapion Builder waiting for a Nickname & a Level
		/// </summary>
		public Drapion(string nickname, int level)
		: base(
				452,
				SpecieDrapion.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drapion Builder only waiting for a Level
		/// </summary>
		public Drapion(int level)
		: base(
				452,
				SpecieDrapion.Instance, // Pokemon Specie
				"Drapion", level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drapion Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Drapion() : base(
			452,
			SpecieDrapion.Instance, // Pokemon Specie
			Poison.Instance, Dark.Instance			
		) {}
		#endregion
	}
	#endregion
}