using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Drampa Specie to store common natural stats of all Drampas
	#region SpecieDrampa
	public class SpecieDrampa : PokemonSpecie
	{
#nullable enable
		private static SpecieDrampa? _instance = null;
#nullable restore
        public static SpecieDrampa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrampa();
                }
                return _instance;
            }
        }

		#region SpecieDrampa Builder
		public SpecieDrampa() : base(
			"Drampa",
			3.0,
			185.0,
			78, // HPs
			60, 85, // Attack & Defense
			135, 91, // Special Attack & Defense
			36		
		)
		{}
		#endregion
	}
	#endregion

	//Drampa Pokemon Class
	#region Drampa
	public class Drampa : Pokemon
	{
		#region Drampa Builders
		/// <summary>
		/// Drampa Builder waiting for a Nickname & a Level
		/// </summary>
		public Drampa(string nickname, int level)
		: base(
				780,
				SpecieDrampa.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drampa Builder only waiting for a Level
		/// </summary>
		public Drampa(int level)
		: base(
				780,
				SpecieDrampa.Instance, // Pokemon Specie
				"Drampa", level,
				Normal.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drampa Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Drampa() : base(
			780,
			SpecieDrampa.Instance, // Pokemon Specie
			Normal.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}