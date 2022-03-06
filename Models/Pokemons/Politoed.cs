using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Politoed Specie to store common natural stats of all Politoeds
	#region SpeciePolitoed
	public class SpeciePolitoed : PokemonSpecie
	{
#nullable enable
		private static SpeciePolitoed? _instance = null;
#nullable restore
        public static SpeciePolitoed Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePolitoed();
                }
                return _instance;
            }
        }

		#region SpeciePolitoed Builder
		public SpeciePolitoed() : base(
			"Politoed",
			1.1,
			33.9,
			90, // HPs
			75, 75, // Attack & Defense
			90, 100, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Politoed Pokemon Class
	#region Politoed
	public class Politoed : Pokemon
	{
		#region Politoed Builders
		/// <summary>
		/// Politoed Builder waiting for a Nickname & a Level
		/// </summary>
		public Politoed(string nickname, int level)
		: base(
				186,
				SpeciePolitoed.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Politoed Builder only waiting for a Level
		/// </summary>
		public Politoed(int level)
		: base(
				186,
				SpeciePolitoed.Instance, // Pokemon Specie
				"Politoed", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Politoed Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Politoed() : base(
			186,
			SpeciePolitoed.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}