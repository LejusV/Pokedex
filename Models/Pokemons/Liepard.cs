using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Liepard Specie to store common natural stats of all Liepards
	#region SpecieLiepard
	public class SpecieLiepard : PokemonSpecie
	{
#nullable enable
		private static SpecieLiepard? _instance = null;
#nullable restore
        public static SpecieLiepard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLiepard();
                }
                return _instance;
            }
        }

		#region SpecieLiepard Builder
		public SpecieLiepard() : base(
			"Liepard",
			64, // HPs
			88, 50, // Attack & Defense
			88, 50, // Special Attack & Defense
			106		
		)
		{
			this._height = 11;
			this._weight = 375;
		}
		#endregion
	}
	#endregion

	//Liepard Pokemon Class
	#region Liepard
	public class Liepard : Pokemon
	{
		#region Liepard Builders
		/// <summary>
		/// Liepard Builder waiting for a Nickname & a Level
		/// </summary>
		public Liepard(string nickname, int level)
		: base(
				510,
				SpecieLiepard.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Liepard Builder only waiting for a Level
		/// </summary>
		public Liepard(int level)
		: base(
				510,
				SpecieLiepard.Instance, // Pokemon Specie
				"Liepard", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Liepard Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Liepard() : base(
			510,
			SpecieLiepard.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}