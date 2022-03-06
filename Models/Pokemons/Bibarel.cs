using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bibarel Specie to store common natural stats of all Bibarels
	#region SpecieBibarel
	public class SpecieBibarel : PokemonSpecie
	{
#nullable enable
		private static SpecieBibarel? _instance = null;
#nullable restore
        public static SpecieBibarel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBibarel();
                }
                return _instance;
            }
        }

		#region SpecieBibarel Builder
		public SpecieBibarel() : base(
			"Bibarel",
			79, // HPs
			85, 60, // Attack & Defense
			55, 60, // Special Attack & Defense
			71		
		)
		{
			this._height = 10;
			this._weight = 315;
		}
		#endregion
	}
	#endregion

	//Bibarel Pokemon Class
	#region Bibarel
	public class Bibarel : Pokemon
	{
		#region Bibarel Builders
		/// <summary>
		/// Bibarel Builder waiting for a Nickname & a Level
		/// </summary>
		public Bibarel(string nickname, int level)
		: base(
				400,
				SpecieBibarel.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bibarel Builder only waiting for a Level
		/// </summary>
		public Bibarel(int level)
		: base(
				400,
				SpecieBibarel.Instance, // Pokemon Specie
				"Bibarel", level,
				Normal.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bibarel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bibarel() : base(
			400,
			SpecieBibarel.Instance, // Pokemon Specie
			Normal.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}