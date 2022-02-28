using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Machamp Specie to store common natural stats of all Machamps
	#region SpecieMachamp
	public class SpecieMachamp : PokemonSpecie
	{
#nullable enable
		private static SpecieMachamp? _instance = null;
#nullable restore
        public static SpecieMachamp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMachamp();
                }
                return _instance;
            }
        }

		#region SpecieMachamp Builder
		public SpecieMachamp() : base(
			"Machamp",
			90, // HPs
			130, 80, // Attack & Defense
			65, 85, // Special Attack & Defense
			55			
		) {}
		#endregion
	}
	#endregion

	//Machamp Pokemon Class
	#region Machamp
	public class Machamp : Pokemon
	{
		#region Machamp Builders
		/// <summary>
		/// Machamp Builder waiting for a Nickname & a Level
		/// </summary>
		public Machamp(string nickname, int level)
		: base(
				68,
				SpecieMachamp.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machamp Builder only waiting for a Level
		/// </summary>
		public Machamp(int level)
		: base(
				68,
				SpecieMachamp.Instance, // Pokemon Specie
				"Machamp", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machamp Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Machamp() : base(
			68,
			SpecieMachamp.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}