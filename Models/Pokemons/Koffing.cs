using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Koffing Specie to store common natural stats of all Koffings
	#region SpecieKoffing
	public class SpecieKoffing : PokemonSpecie
	{
#nullable enable
		private static SpecieKoffing? _instance = null;
#nullable restore
        public static SpecieKoffing Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKoffing();
                }
                return _instance;
            }
        }

		#region SpecieKoffing Builder
		public SpecieKoffing() : base(
			"Koffing",
			0.6,
			1.0,
			40, // HPs
			65, 95, // Attack & Defense
			60, 45, // Special Attack & Defense
			35		
		)
		{}
		#endregion
	}
	#endregion

	//Koffing Pokemon Class
	#region Koffing
	public class Koffing : Pokemon
	{
		#region Koffing Builders
		/// <summary>
		/// Koffing Builder waiting for a Nickname & a Level
		/// </summary>
		public Koffing(string nickname, int level)
		: base(
				109,
				SpecieKoffing.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Koffing Builder only waiting for a Level
		/// </summary>
		public Koffing(int level)
		: base(
				109,
				SpecieKoffing.Instance, // Pokemon Specie
				"Koffing", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Koffing Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Koffing() : base(
			109,
			SpecieKoffing.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}