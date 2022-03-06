using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dewott Specie to store common natural stats of all Dewotts
	#region SpecieDewott
	public class SpecieDewott : PokemonSpecie
	{
#nullable enable
		private static SpecieDewott? _instance = null;
#nullable restore
        public static SpecieDewott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDewott();
                }
                return _instance;
            }
        }

		#region SpecieDewott Builder
		public SpecieDewott() : base(
			"Dewott",
			0.8,
			24.5,
			75, // HPs
			75, 60, // Attack & Defense
			83, 60, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Dewott Pokemon Class
	#region Dewott
	public class Dewott : Pokemon
	{
		#region Dewott Builders
		/// <summary>
		/// Dewott Builder waiting for a Nickname & a Level
		/// </summary>
		public Dewott(string nickname, int level)
		: base(
				502,
				SpecieDewott.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewott Builder only waiting for a Level
		/// </summary>
		public Dewott(int level)
		: base(
				502,
				SpecieDewott.Instance, // Pokemon Specie
				"Dewott", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewott Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dewott() : base(
			502,
			SpecieDewott.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}