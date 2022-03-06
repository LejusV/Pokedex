using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Frillish Specie to store common natural stats of all Frillishs
	#region SpecieFrillish
	public class SpecieFrillish : PokemonSpecie
	{
#nullable enable
		private static SpecieFrillish? _instance = null;
#nullable restore
        public static SpecieFrillish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFrillish();
                }
                return _instance;
            }
        }

		#region SpecieFrillish Builder
		public SpecieFrillish() : base(
			"Frillish",
			1.2,
			33.0,
			55, // HPs
			40, 50, // Attack & Defense
			65, 85, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Frillish Pokemon Class
	#region Frillish
	public class Frillish : Pokemon
	{
		#region Frillish Builders
		/// <summary>
		/// Frillish Builder waiting for a Nickname & a Level
		/// </summary>
		public Frillish(string nickname, int level)
		: base(
				592,
				SpecieFrillish.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frillish Builder only waiting for a Level
		/// </summary>
		public Frillish(int level)
		: base(
				592,
				SpecieFrillish.Instance, // Pokemon Specie
				"Frillish", level,
				Water.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frillish Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Frillish() : base(
			592,
			SpecieFrillish.Instance, // Pokemon Specie
			Water.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}