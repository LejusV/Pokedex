using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Rapidash Specie to store common natural stats of all Rapidashs
	#region SpecieRapidash
	public class SpecieRapidash : PokemonSpecie
	{
#nullable enable
		private static SpecieRapidash? _instance = null;
#nullable restore
        public static SpecieRapidash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRapidash();
                }
                return _instance;
            }
        }

		#region SpecieRapidash Builder
		public SpecieRapidash() : base(
			"Rapidash",
			1.7,
			95.0,
			65, // HPs
			100, 70, // Attack & Defense
			80, 80, // Special Attack & Defense
			105		
		)
		{}
		#endregion
	}
	#endregion

	//Rapidash Pokemon Class
	#region Rapidash
	public class Rapidash : Pokemon
	{
		#region Rapidash Builders
		/// <summary>
		/// Rapidash Builder waiting for a Nickname & a Level
		/// </summary>
		public Rapidash(string nickname, int level)
		: base(
				78,
				SpecieRapidash.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rapidash Builder only waiting for a Level
		/// </summary>
		public Rapidash(int level)
		: base(
				78,
				SpecieRapidash.Instance, // Pokemon Specie
				"Rapidash", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rapidash Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Rapidash() : base(
			78,
			SpecieRapidash.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}