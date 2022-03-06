using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Piplup Specie to store common natural stats of all Piplups
	#region SpeciePiplup
	public class SpeciePiplup : PokemonSpecie
	{
#nullable enable
		private static SpeciePiplup? _instance = null;
#nullable restore
        public static SpeciePiplup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePiplup();
                }
                return _instance;
            }
        }

		#region SpeciePiplup Builder
		public SpeciePiplup() : base(
			"Piplup",
			0.4,
			5.2,
			53, // HPs
			51, 53, // Attack & Defense
			61, 56, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Piplup Pokemon Class
	#region Piplup
	public class Piplup : Pokemon
	{
		#region Piplup Builders
		/// <summary>
		/// Piplup Builder waiting for a Nickname & a Level
		/// </summary>
		public Piplup(string nickname, int level)
		: base(
				393,
				SpeciePiplup.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piplup Builder only waiting for a Level
		/// </summary>
		public Piplup(int level)
		: base(
				393,
				SpeciePiplup.Instance, // Pokemon Specie
				"Piplup", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piplup Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Piplup() : base(
			393,
			SpeciePiplup.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}