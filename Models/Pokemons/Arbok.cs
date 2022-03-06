using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Arbok Specie to store common natural stats of all Arboks
	#region SpecieArbok
	public class SpecieArbok : PokemonSpecie
	{
#nullable enable
		private static SpecieArbok? _instance = null;
#nullable restore
        public static SpecieArbok Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArbok();
                }
                return _instance;
            }
        }

		#region SpecieArbok Builder
		public SpecieArbok() : base(
			"Arbok",
			3.5,
			65.0,
			60, // HPs
			95, 69, // Attack & Defense
			65, 79, // Special Attack & Defense
			80		
		)
		{}
		#endregion
	}
	#endregion

	//Arbok Pokemon Class
	#region Arbok
	public class Arbok : Pokemon
	{
		#region Arbok Builders
		/// <summary>
		/// Arbok Builder waiting for a Nickname & a Level
		/// </summary>
		public Arbok(string nickname, int level)
		: base(
				24,
				SpecieArbok.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arbok Builder only waiting for a Level
		/// </summary>
		public Arbok(int level)
		: base(
				24,
				SpecieArbok.Instance, // Pokemon Specie
				"Arbok", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arbok Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Arbok() : base(
			24,
			SpecieArbok.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}