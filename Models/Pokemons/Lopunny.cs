using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lopunny Specie to store common natural stats of all Lopunnys
	#region SpecieLopunny
	public class SpecieLopunny : PokemonSpecie
	{
#nullable enable
		private static SpecieLopunny? _instance = null;
#nullable restore
        public static SpecieLopunny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLopunny();
                }
                return _instance;
            }
        }

		#region SpecieLopunny Builder
		public SpecieLopunny() : base(
			"Lopunny",
			1.2,
			33.3,
			65, // HPs
			76, 84, // Attack & Defense
			54, 96, // Special Attack & Defense
			105		
		)
		{}
		#endregion
	}
	#endregion

	//Lopunny Pokemon Class
	#region Lopunny
	public class Lopunny : Pokemon
	{
		#region Lopunny Builders
		/// <summary>
		/// Lopunny Builder waiting for a Nickname & a Level
		/// </summary>
		public Lopunny(string nickname, int level)
		: base(
				428,
				SpecieLopunny.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lopunny Builder only waiting for a Level
		/// </summary>
		public Lopunny(int level)
		: base(
				428,
				SpecieLopunny.Instance, // Pokemon Specie
				"Lopunny", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lopunny Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lopunny() : base(
			428,
			SpecieLopunny.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}