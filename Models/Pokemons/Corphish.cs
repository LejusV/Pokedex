using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Corphish Specie to store common natural stats of all Corphishs
	#region SpecieCorphish
	public class SpecieCorphish : PokemonSpecie
	{
#nullable enable
		private static SpecieCorphish? _instance = null;
#nullable restore
        public static SpecieCorphish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCorphish();
                }
                return _instance;
            }
        }

		#region SpecieCorphish Builder
		public SpecieCorphish() : base(
			"Corphish",
			0.6,
			11.5,
			43, // HPs
			80, 65, // Attack & Defense
			50, 35, // Special Attack & Defense
			35		
		)
		{}
		#endregion
	}
	#endregion

	//Corphish Pokemon Class
	#region Corphish
	public class Corphish : Pokemon
	{
		#region Corphish Builders
		/// <summary>
		/// Corphish Builder waiting for a Nickname & a Level
		/// </summary>
		public Corphish(string nickname, int level)
		: base(
				341,
				SpecieCorphish.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corphish Builder only waiting for a Level
		/// </summary>
		public Corphish(int level)
		: base(
				341,
				SpecieCorphish.Instance, // Pokemon Specie
				"Corphish", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corphish Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Corphish() : base(
			341,
			SpecieCorphish.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}