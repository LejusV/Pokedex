using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Jirachi Specie to store common natural stats of all Jirachis
	#region SpecieJirachi
	public class SpecieJirachi : PokemonSpecie
	{
#nullable enable
		private static SpecieJirachi? _instance = null;
#nullable restore
        public static SpecieJirachi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJirachi();
                }
                return _instance;
            }
        }

		#region SpecieJirachi Builder
		public SpecieJirachi() : base(
			"Jirachi",
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100		
		)
		{
			this._height = 3;
			this._weight = 11;
		}
		#endregion
	}
	#endregion

	//Jirachi Pokemon Class
	#region Jirachi
	public class Jirachi : Pokemon
	{
		#region Jirachi Builders
		/// <summary>
		/// Jirachi Builder waiting for a Nickname & a Level
		/// </summary>
		public Jirachi(string nickname, int level)
		: base(
				385,
				SpecieJirachi.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jirachi Builder only waiting for a Level
		/// </summary>
		public Jirachi(int level)
		: base(
				385,
				SpecieJirachi.Instance, // Pokemon Specie
				"Jirachi", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jirachi Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Jirachi() : base(
			385,
			SpecieJirachi.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}