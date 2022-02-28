using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Illumise Specie to store common natural stats of all Illumises
	#region SpecieIllumise
	public class SpecieIllumise : PokemonSpecie
	{
#nullable enable
		private static SpecieIllumise? _instance = null;
#nullable restore
        public static SpecieIllumise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieIllumise();
                }
                return _instance;
            }
        }

		#region SpecieIllumise Builder
		public SpecieIllumise() : base(
			"Illumise",
			65, // HPs
			47, 75, // Attack & Defense
			73, 85, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Illumise Pokemon Class
	#region Illumise
	public class Illumise : Pokemon
	{
		#region Illumise Builders
		/// <summary>
		/// Illumise Builder waiting for a Nickname & a Level
		/// </summary>
		public Illumise(string nickname, int level)
		: base(
				314,
				SpecieIllumise.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Illumise Builder only waiting for a Level
		/// </summary>
		public Illumise(int level)
		: base(
				314,
				SpecieIllumise.Instance, // Pokemon Specie
				"Illumise", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Illumise Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Illumise() : base(
			314,
			SpecieIllumise.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}