using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Palpitoad Specie to store common natural stats of all Palpitoads
	#region SpeciePalpitoad
	public class SpeciePalpitoad : PokemonSpecie
	{
#nullable enable
		private static SpeciePalpitoad? _instance = null;
#nullable restore
        public static SpeciePalpitoad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePalpitoad();
                }
                return _instance;
            }
        }

		#region SpeciePalpitoad Builder
		public SpeciePalpitoad() : base(
			"Palpitoad",
			75, // HPs
			65, 55, // Attack & Defense
			65, 55, // Special Attack & Defense
			69		
		)
		{
			this._height = 8;
			this._weight = 170;
		}
		#endregion
	}
	#endregion

	//Palpitoad Pokemon Class
	#region Palpitoad
	public class Palpitoad : Pokemon
	{
		#region Palpitoad Builders
		/// <summary>
		/// Palpitoad Builder waiting for a Nickname & a Level
		/// </summary>
		public Palpitoad(string nickname, int level)
		: base(
				536,
				SpeciePalpitoad.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palpitoad Builder only waiting for a Level
		/// </summary>
		public Palpitoad(int level)
		: base(
				536,
				SpeciePalpitoad.Instance, // Pokemon Specie
				"Palpitoad", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palpitoad Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Palpitoad() : base(
			536,
			SpeciePalpitoad.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}