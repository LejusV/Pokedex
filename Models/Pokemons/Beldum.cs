using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Beldum Specie to store common natural stats of all Beldums
	#region SpecieBeldum
	public class SpecieBeldum : PokemonSpecie
	{
#nullable enable
		private static SpecieBeldum? _instance = null;
#nullable restore
        public static SpecieBeldum Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBeldum();
                }
                return _instance;
            }
        }

		#region SpecieBeldum Builder
		public SpecieBeldum() : base(
			"Beldum",
			40, // HPs
			55, 80, // Attack & Defense
			35, 60, // Special Attack & Defense
			30		
		)
		{
			this._height = 6;
			this._weight = 952;
		}
		#endregion
	}
	#endregion

	//Beldum Pokemon Class
	#region Beldum
	public class Beldum : Pokemon
	{
		#region Beldum Builders
		/// <summary>
		/// Beldum Builder waiting for a Nickname & a Level
		/// </summary>
		public Beldum(string nickname, int level)
		: base(
				374,
				SpecieBeldum.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beldum Builder only waiting for a Level
		/// </summary>
		public Beldum(int level)
		: base(
				374,
				SpecieBeldum.Instance, // Pokemon Specie
				"Beldum", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beldum Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Beldum() : base(
			374,
			SpecieBeldum.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}