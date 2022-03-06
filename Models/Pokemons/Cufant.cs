using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cufant Specie to store common natural stats of all Cufants
	#region SpecieCufant
	public class SpecieCufant : PokemonSpecie
	{
#nullable enable
		private static SpecieCufant? _instance = null;
#nullable restore
        public static SpecieCufant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCufant();
                }
                return _instance;
            }
        }

		#region SpecieCufant Builder
		public SpecieCufant() : base(
			"Cufant",
			72, // HPs
			80, 49, // Attack & Defense
			40, 49, // Special Attack & Defense
			40		
		)
		{
			this._height = 12;
			this._weight = 1000;
		}
		#endregion
	}
	#endregion

	//Cufant Pokemon Class
	#region Cufant
	public class Cufant : Pokemon
	{
		#region Cufant Builders
		/// <summary>
		/// Cufant Builder waiting for a Nickname & a Level
		/// </summary>
		public Cufant(string nickname, int level)
		: base(
				878,
				SpecieCufant.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cufant Builder only waiting for a Level
		/// </summary>
		public Cufant(int level)
		: base(
				878,
				SpecieCufant.Instance, // Pokemon Specie
				"Cufant", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cufant Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cufant() : base(
			878,
			SpecieCufant.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}