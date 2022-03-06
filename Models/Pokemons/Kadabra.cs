using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kadabra Specie to store common natural stats of all Kadabras
	#region SpecieKadabra
	public class SpecieKadabra : PokemonSpecie
	{
#nullable enable
		private static SpecieKadabra? _instance = null;
#nullable restore
        public static SpecieKadabra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKadabra();
                }
                return _instance;
            }
        }

		#region SpecieKadabra Builder
		public SpecieKadabra() : base(
			"Kadabra",
			1.3,
			56.5,
			40, // HPs
			35, 30, // Attack & Defense
			120, 70, // Special Attack & Defense
			105		
		)
		{}
		#endregion
	}
	#endregion

	//Kadabra Pokemon Class
	#region Kadabra
	public class Kadabra : Pokemon
	{
		#region Kadabra Builders
		/// <summary>
		/// Kadabra Builder waiting for a Nickname & a Level
		/// </summary>
		public Kadabra(string nickname, int level)
		: base(
				64,
				SpecieKadabra.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kadabra Builder only waiting for a Level
		/// </summary>
		public Kadabra(int level)
		: base(
				64,
				SpecieKadabra.Instance, // Pokemon Specie
				"Kadabra", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kadabra Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kadabra() : base(
			64,
			SpecieKadabra.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}