using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cinderace Specie to store common natural stats of all Cinderaces
	#region SpecieCinderace
	public class SpecieCinderace : PokemonSpecie
	{
#nullable enable
		private static SpecieCinderace? _instance = null;
#nullable restore
        public static SpecieCinderace Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCinderace();
                }
                return _instance;
            }
        }

		#region SpecieCinderace Builder
		public SpecieCinderace() : base(
			"Cinderace",
			80, // HPs
			116, 75, // Attack & Defense
			65, 75, // Special Attack & Defense
			119		
		)
		{
			this._height = 14;
			this._weight = 330;
		}
		#endregion
	}
	#endregion

	//Cinderace Pokemon Class
	#region Cinderace
	public class Cinderace : Pokemon
	{
		#region Cinderace Builders
		/// <summary>
		/// Cinderace Builder waiting for a Nickname & a Level
		/// </summary>
		public Cinderace(string nickname, int level)
		: base(
				815,
				SpecieCinderace.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinderace Builder only waiting for a Level
		/// </summary>
		public Cinderace(int level)
		: base(
				815,
				SpecieCinderace.Instance, // Pokemon Specie
				"Cinderace", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinderace Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cinderace() : base(
			815,
			SpecieCinderace.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}