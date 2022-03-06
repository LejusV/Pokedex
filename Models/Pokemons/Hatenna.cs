using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Hatenna Specie to store common natural stats of all Hatennas
	#region SpecieHatenna
	public class SpecieHatenna : PokemonSpecie
	{
#nullable enable
		private static SpecieHatenna? _instance = null;
#nullable restore
        public static SpecieHatenna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHatenna();
                }
                return _instance;
            }
        }

		#region SpecieHatenna Builder
		public SpecieHatenna() : base(
			"Hatenna",
			0.4,
			3.4,
			42, // HPs
			30, 45, // Attack & Defense
			56, 53, // Special Attack & Defense
			39		
		)
		{}
		#endregion
	}
	#endregion

	//Hatenna Pokemon Class
	#region Hatenna
	public class Hatenna : Pokemon
	{
		#region Hatenna Builders
		/// <summary>
		/// Hatenna Builder waiting for a Nickname & a Level
		/// </summary>
		public Hatenna(string nickname, int level)
		: base(
				856,
				SpecieHatenna.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatenna Builder only waiting for a Level
		/// </summary>
		public Hatenna(int level)
		: base(
				856,
				SpecieHatenna.Instance, // Pokemon Specie
				"Hatenna", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatenna Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Hatenna() : base(
			856,
			SpecieHatenna.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}