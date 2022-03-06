using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pikipek Specie to store common natural stats of all Pikipeks
	#region SpeciePikipek
	public class SpeciePikipek : PokemonSpecie
	{
#nullable enable
		private static SpeciePikipek? _instance = null;
#nullable restore
        public static SpeciePikipek Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePikipek();
                }
                return _instance;
            }
        }

		#region SpeciePikipek Builder
		public SpeciePikipek() : base(
			"Pikipek",
			35, // HPs
			75, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			65		
		)
		{
			this._height = 3;
			this._weight = 12;
		}
		#endregion
	}
	#endregion

	//Pikipek Pokemon Class
	#region Pikipek
	public class Pikipek : Pokemon
	{
		#region Pikipek Builders
		/// <summary>
		/// Pikipek Builder waiting for a Nickname & a Level
		/// </summary>
		public Pikipek(string nickname, int level)
		: base(
				731,
				SpeciePikipek.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikipek Builder only waiting for a Level
		/// </summary>
		public Pikipek(int level)
		: base(
				731,
				SpeciePikipek.Instance, // Pokemon Specie
				"Pikipek", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikipek Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pikipek() : base(
			731,
			SpeciePikipek.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}