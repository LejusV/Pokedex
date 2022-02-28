using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Crabominable Specie to store common natural stats of all Crabominables
	#region SpecieCrabominable
	public class SpecieCrabominable : PokemonSpecie
	{
#nullable enable
		private static SpecieCrabominable? _instance = null;
#nullable restore
        public static SpecieCrabominable Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCrabominable();
                }
                return _instance;
            }
        }

		#region SpecieCrabominable Builder
		public SpecieCrabominable() : base(
			"Crabominable",
			97, // HPs
			132, 77, // Attack & Defense
			62, 67, // Special Attack & Defense
			43			
		) {}
		#endregion
	}
	#endregion

	//Crabominable Pokemon Class
	#region Crabominable
	public class Crabominable : Pokemon
	{
		#region Crabominable Builders
		/// <summary>
		/// Crabominable Builder waiting for a Nickname & a Level
		/// </summary>
		public Crabominable(string nickname, int level)
		: base(
				740,
				SpecieCrabominable.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabominable Builder only waiting for a Level
		/// </summary>
		public Crabominable(int level)
		: base(
				740,
				SpecieCrabominable.Instance, // Pokemon Specie
				"Crabominable", level,
				Fighting.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabominable Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Crabominable() : base(
			740,
			SpecieCrabominable.Instance, // Pokemon Specie
			Fighting.Instance, Ice.Instance			
		) {}
		#endregion
	}
	#endregion
}