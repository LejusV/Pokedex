using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Meltan Specie to store common natural stats of all Meltans
	#region SpecieMeltan
	public class SpecieMeltan : PokemonSpecie
	{
#nullable enable
		private static SpecieMeltan? _instance = null;
#nullable restore
        public static SpecieMeltan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeltan();
                }
                return _instance;
            }
        }

		#region SpecieMeltan Builder
		public SpecieMeltan() : base(
			"Meltan",
			0.2,
			8.0,
			46, // HPs
			65, 65, // Attack & Defense
			55, 35, // Special Attack & Defense
			34		
		)
		{}
		#endregion
	}
	#endregion

	//Meltan Pokemon Class
	#region Meltan
	public class Meltan : Pokemon
	{
		#region Meltan Builders
		/// <summary>
		/// Meltan Builder waiting for a Nickname & a Level
		/// </summary>
		public Meltan(string nickname, int level)
		: base(
				808,
				SpecieMeltan.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meltan Builder only waiting for a Level
		/// </summary>
		public Meltan(int level)
		: base(
				808,
				SpecieMeltan.Instance, // Pokemon Specie
				"Meltan", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meltan Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Meltan() : base(
			808,
			SpecieMeltan.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}