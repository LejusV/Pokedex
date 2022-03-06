using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bronzong Specie to store common natural stats of all Bronzongs
	#region SpecieBronzong
	public class SpecieBronzong : PokemonSpecie
	{
#nullable enable
		private static SpecieBronzong? _instance = null;
#nullable restore
        public static SpecieBronzong Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBronzong();
                }
                return _instance;
            }
        }

		#region SpecieBronzong Builder
		public SpecieBronzong() : base(
			"Bronzong",
			1.3,
			187.0,
			67, // HPs
			89, 116, // Attack & Defense
			79, 116, // Special Attack & Defense
			33		
		)
		{}
		#endregion
	}
	#endregion

	//Bronzong Pokemon Class
	#region Bronzong
	public class Bronzong : Pokemon
	{
		#region Bronzong Builders
		/// <summary>
		/// Bronzong Builder waiting for a Nickname & a Level
		/// </summary>
		public Bronzong(string nickname, int level)
		: base(
				437,
				SpecieBronzong.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzong Builder only waiting for a Level
		/// </summary>
		public Bronzong(int level)
		: base(
				437,
				SpecieBronzong.Instance, // Pokemon Specie
				"Bronzong", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bronzong Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bronzong() : base(
			437,
			SpecieBronzong.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}