using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lumineon Specie to store common natural stats of all Lumineons
	#region SpecieLumineon
	public class SpecieLumineon : PokemonSpecie
	{
#nullable enable
		private static SpecieLumineon? _instance = null;
#nullable restore
        public static SpecieLumineon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLumineon();
                }
                return _instance;
            }
        }

		#region SpecieLumineon Builder
		public SpecieLumineon() : base(
			"Lumineon",
			69, // HPs
			69, 76, // Attack & Defense
			69, 86, // Special Attack & Defense
			91		
		)
		{
			this._height = 12;
			this._weight = 240;
		}
		#endregion
	}
	#endregion

	//Lumineon Pokemon Class
	#region Lumineon
	public class Lumineon : Pokemon
	{
		#region Lumineon Builders
		/// <summary>
		/// Lumineon Builder waiting for a Nickname & a Level
		/// </summary>
		public Lumineon(string nickname, int level)
		: base(
				457,
				SpecieLumineon.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lumineon Builder only waiting for a Level
		/// </summary>
		public Lumineon(int level)
		: base(
				457,
				SpecieLumineon.Instance, // Pokemon Specie
				"Lumineon", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lumineon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lumineon() : base(
			457,
			SpecieLumineon.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}