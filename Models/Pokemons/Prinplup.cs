using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Prinplup Specie to store common natural stats of all Prinplups
	#region SpeciePrinplup
	public class SpeciePrinplup : PokemonSpecie
	{
#nullable enable
		private static SpeciePrinplup? _instance = null;
#nullable restore
        public static SpeciePrinplup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePrinplup();
                }
                return _instance;
            }
        }

		#region SpeciePrinplup Builder
		public SpeciePrinplup() : base(
			"Prinplup",
			64, // HPs
			66, 68, // Attack & Defense
			81, 76, // Special Attack & Defense
			50		
		)
		{
			this._height = 8;
			this._weight = 230;
		}
		#endregion
	}
	#endregion

	//Prinplup Pokemon Class
	#region Prinplup
	public class Prinplup : Pokemon
	{
		#region Prinplup Builders
		/// <summary>
		/// Prinplup Builder waiting for a Nickname & a Level
		/// </summary>
		public Prinplup(string nickname, int level)
		: base(
				394,
				SpeciePrinplup.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Prinplup Builder only waiting for a Level
		/// </summary>
		public Prinplup(int level)
		: base(
				394,
				SpeciePrinplup.Instance, // Pokemon Specie
				"Prinplup", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Prinplup Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Prinplup() : base(
			394,
			SpeciePrinplup.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}