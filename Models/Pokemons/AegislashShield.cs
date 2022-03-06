using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Aegislash-Shield Specie to store common natural stats of all Aegislash-Shields
	#region SpecieAegislash-Shield
	public class SpecieAegislashShield : PokemonSpecie
	{
#nullable enable
		private static SpecieAegislashShield? _instance = null;
#nullable restore
        public static SpecieAegislashShield Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAegislashShield();
                }
                return _instance;
            }
        }

		#region SpecieAegislash-Shield Builder
		public SpecieAegislashShield() : base(
			"Aegislash-Shield",
			1.7,
			53.0,
			60, // HPs
			50, 140, // Attack & Defense
			50, 140, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Aegislash-Shield Pokemon Class
	#region Aegislash-Shield
	public class AegislashShield : Pokemon
	{
		#region Aegislash-Shield Builders
		/// <summary>
		/// Aegislash-Shield Builder waiting for a Nickname & a Level
		/// </summary>
		public AegislashShield(string nickname, int level)
		: base(
				681,
				SpecieAegislashShield.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aegislash-Shield Builder only waiting for a Level
		/// </summary>
		public AegislashShield(int level)
		: base(
				681,
				SpecieAegislashShield.Instance, // Pokemon Specie
				"Aegislash-Shield", level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aegislash-Shield Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public AegislashShield() : base(
			681,
			SpecieAegislashShield.Instance, // Pokemon Specie
			Steel.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}