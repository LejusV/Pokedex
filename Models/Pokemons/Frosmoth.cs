using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Frosmoth Specie to store common natural stats of all Frosmoths
	#region SpecieFrosmoth
	public class SpecieFrosmoth : PokemonSpecie
	{
#nullable enable
		private static SpecieFrosmoth? _instance = null;
#nullable restore
        public static SpecieFrosmoth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFrosmoth();
                }
                return _instance;
            }
        }

		#region SpecieFrosmoth Builder
		public SpecieFrosmoth() : base(
			"Frosmoth",
			70, // HPs
			65, 60, // Attack & Defense
			125, 90, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Frosmoth Pokemon Class
	#region Frosmoth
	public class Frosmoth : Pokemon
	{
		#region Frosmoth Builders
		/// <summary>
		/// Frosmoth Builder waiting for a Nickname & a Level
		/// </summary>
		public Frosmoth(string nickname, int level)
		: base(
				873,
				SpecieFrosmoth.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frosmoth Builder only waiting for a Level
		/// </summary>
		public Frosmoth(int level)
		: base(
				873,
				SpecieFrosmoth.Instance, // Pokemon Specie
				"Frosmoth", level,
				Ice.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frosmoth Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Frosmoth() : base(
			873,
			SpecieFrosmoth.Instance, // Pokemon Specie
			Ice.Instance, Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}