using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sandaconda Specie to store common natural stats of all Sandacondas
	#region SpecieSandaconda
	public class SpecieSandaconda : PokemonSpecie
	{
#nullable enable
		private static SpecieSandaconda? _instance = null;
#nullable restore
        public static SpecieSandaconda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSandaconda();
                }
                return _instance;
            }
        }

		#region SpecieSandaconda Builder
		public SpecieSandaconda() : base(
			"Sandaconda",
			3.8,
			65.5,
			72, // HPs
			107, 125, // Attack & Defense
			65, 70, // Special Attack & Defense
			71		
		)
		{}
		#endregion
	}
	#endregion

	//Sandaconda Pokemon Class
	#region Sandaconda
	public class Sandaconda : Pokemon
	{
		#region Sandaconda Builders
		/// <summary>
		/// Sandaconda Builder waiting for a Nickname & a Level
		/// </summary>
		public Sandaconda(string nickname, int level)
		: base(
				844,
				SpecieSandaconda.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandaconda Builder only waiting for a Level
		/// </summary>
		public Sandaconda(int level)
		: base(
				844,
				SpecieSandaconda.Instance, // Pokemon Specie
				"Sandaconda", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandaconda Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sandaconda() : base(
			844,
			SpecieSandaconda.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}