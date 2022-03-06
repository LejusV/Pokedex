using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Popplio Specie to store common natural stats of all Popplios
	#region SpeciePopplio
	public class SpeciePopplio : PokemonSpecie
	{
#nullable enable
		private static SpeciePopplio? _instance = null;
#nullable restore
        public static SpeciePopplio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePopplio();
                }
                return _instance;
            }
        }

		#region SpeciePopplio Builder
		public SpeciePopplio() : base(
			"Popplio",
			50, // HPs
			54, 54, // Attack & Defense
			66, 56, // Special Attack & Defense
			40		
		)
		{
			this._height = 4;
			this._weight = 75;
		}
		#endregion
	}
	#endregion

	//Popplio Pokemon Class
	#region Popplio
	public class Popplio : Pokemon
	{
		#region Popplio Builders
		/// <summary>
		/// Popplio Builder waiting for a Nickname & a Level
		/// </summary>
		public Popplio(string nickname, int level)
		: base(
				728,
				SpeciePopplio.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Popplio Builder only waiting for a Level
		/// </summary>
		public Popplio(int level)
		: base(
				728,
				SpeciePopplio.Instance, // Pokemon Specie
				"Popplio", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Popplio Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Popplio() : base(
			728,
			SpeciePopplio.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}