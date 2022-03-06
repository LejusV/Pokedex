using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cursola Specie to store common natural stats of all Cursolas
	#region SpecieCursola
	public class SpecieCursola : PokemonSpecie
	{
#nullable enable
		private static SpecieCursola? _instance = null;
#nullable restore
        public static SpecieCursola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCursola();
                }
                return _instance;
            }
        }

		#region SpecieCursola Builder
		public SpecieCursola() : base(
			"Cursola",
			60, // HPs
			95, 50, // Attack & Defense
			145, 130, // Special Attack & Defense
			30		
		)
		{
			this._height = 10;
			this._weight = 4;
		}
		#endregion
	}
	#endregion

	//Cursola Pokemon Class
	#region Cursola
	public class Cursola : Pokemon
	{
		#region Cursola Builders
		/// <summary>
		/// Cursola Builder waiting for a Nickname & a Level
		/// </summary>
		public Cursola(string nickname, int level)
		: base(
				864,
				SpecieCursola.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cursola Builder only waiting for a Level
		/// </summary>
		public Cursola(int level)
		: base(
				864,
				SpecieCursola.Instance, // Pokemon Specie
				"Cursola", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cursola Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cursola() : base(
			864,
			SpecieCursola.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}