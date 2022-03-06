using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pincurchin Specie to store common natural stats of all Pincurchins
	#region SpeciePincurchin
	public class SpeciePincurchin : PokemonSpecie
	{
#nullable enable
		private static SpeciePincurchin? _instance = null;
#nullable restore
        public static SpeciePincurchin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePincurchin();
                }
                return _instance;
            }
        }

		#region SpeciePincurchin Builder
		public SpeciePincurchin() : base(
			"Pincurchin",
			0.3,
			1.0,
			48, // HPs
			101, 95, // Attack & Defense
			91, 85, // Special Attack & Defense
			15		
		)
		{}
		#endregion
	}
	#endregion

	//Pincurchin Pokemon Class
	#region Pincurchin
	public class Pincurchin : Pokemon
	{
		#region Pincurchin Builders
		/// <summary>
		/// Pincurchin Builder waiting for a Nickname & a Level
		/// </summary>
		public Pincurchin(string nickname, int level)
		: base(
				871,
				SpeciePincurchin.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pincurchin Builder only waiting for a Level
		/// </summary>
		public Pincurchin(int level)
		: base(
				871,
				SpeciePincurchin.Instance, // Pokemon Specie
				"Pincurchin", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pincurchin Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pincurchin() : base(
			871,
			SpeciePincurchin.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}