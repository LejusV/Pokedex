using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Diancie Specie to store common natural stats of all Diancies
	#region SpecieDiancie
	public class SpecieDiancie : PokemonSpecie
	{
#nullable enable
		private static SpecieDiancie? _instance = null;
#nullable restore
        public static SpecieDiancie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDiancie();
                }
                return _instance;
            }
        }

		#region SpecieDiancie Builder
		public SpecieDiancie() : base(
			"Diancie",
			0.7,
			8.8,
			50, // HPs
			100, 150, // Attack & Defense
			100, 150, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Diancie Pokemon Class
	#region Diancie
	public class Diancie : Pokemon
	{
		#region Diancie Builders
		/// <summary>
		/// Diancie Builder waiting for a Nickname & a Level
		/// </summary>
		public Diancie(string nickname, int level)
		: base(
				719,
				SpecieDiancie.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diancie Builder only waiting for a Level
		/// </summary>
		public Diancie(int level)
		: base(
				719,
				SpecieDiancie.Instance, // Pokemon Specie
				"Diancie", level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diancie Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Diancie() : base(
			719,
			SpecieDiancie.Instance, // Pokemon Specie
			Rock.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}