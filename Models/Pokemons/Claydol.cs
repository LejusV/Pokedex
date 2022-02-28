using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Claydol Specie to store common natural stats of all Claydols
	#region SpecieClaydol
	public class SpecieClaydol : PokemonSpecie
	{
#nullable enable
		private static SpecieClaydol? _instance = null;
#nullable restore
        public static SpecieClaydol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClaydol();
                }
                return _instance;
            }
        }

		#region SpecieClaydol Builder
		public SpecieClaydol() : base(
			"Claydol",
			60, // HPs
			70, 105, // Attack & Defense
			70, 120, // Special Attack & Defense
			75			
		) {}
		#endregion
	}
	#endregion

	//Claydol Pokemon Class
	#region Claydol
	public class Claydol : Pokemon
	{
		#region Claydol Builders
		/// <summary>
		/// Claydol Builder waiting for a Nickname & a Level
		/// </summary>
		public Claydol(string nickname, int level)
		: base(
				344,
				SpecieClaydol.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Claydol Builder only waiting for a Level
		/// </summary>
		public Claydol(int level)
		: base(
				344,
				SpecieClaydol.Instance, // Pokemon Specie
				"Claydol", level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Claydol Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Claydol() : base(
			344,
			SpecieClaydol.Instance, // Pokemon Specie
			Ground.Instance, Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}