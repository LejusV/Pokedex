using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cramorant Specie to store common natural stats of all Cramorants
	#region SpecieCramorant
	public class SpecieCramorant : PokemonSpecie
	{
#nullable enable
		private static SpecieCramorant? _instance = null;
#nullable restore
        public static SpecieCramorant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCramorant();
                }
                return _instance;
            }
        }

		#region SpecieCramorant Builder
		public SpecieCramorant() : base(
			"Cramorant",
			0.8,
			18.0,
			70, // HPs
			85, 55, // Attack & Defense
			85, 95, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Cramorant Pokemon Class
	#region Cramorant
	public class Cramorant : Pokemon
	{
		#region Cramorant Builders
		/// <summary>
		/// Cramorant Builder waiting for a Nickname & a Level
		/// </summary>
		public Cramorant(string nickname, int level)
		: base(
				845,
				SpecieCramorant.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cramorant Builder only waiting for a Level
		/// </summary>
		public Cramorant(int level)
		: base(
				845,
				SpecieCramorant.Instance, // Pokemon Specie
				"Cramorant", level,
				Flying.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cramorant Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cramorant() : base(
			845,
			SpecieCramorant.Instance, // Pokemon Specie
			Flying.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}