using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Elgyem Specie to store common natural stats of all Elgyems
	#region SpecieElgyem
	public class SpecieElgyem : PokemonSpecie
	{
#nullable enable
		private static SpecieElgyem? _instance = null;
#nullable restore
        public static SpecieElgyem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElgyem();
                }
                return _instance;
            }
        }

		#region SpecieElgyem Builder
		public SpecieElgyem() : base(
			"Elgyem",
			0.5,
			9.0,
			55, // HPs
			55, 55, // Attack & Defense
			85, 55, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Elgyem Pokemon Class
	#region Elgyem
	public class Elgyem : Pokemon
	{
		#region Elgyem Builders
		/// <summary>
		/// Elgyem Builder waiting for a Nickname & a Level
		/// </summary>
		public Elgyem(string nickname, int level)
		: base(
				605,
				SpecieElgyem.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elgyem Builder only waiting for a Level
		/// </summary>
		public Elgyem(int level)
		: base(
				605,
				SpecieElgyem.Instance, // Pokemon Specie
				"Elgyem", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elgyem Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Elgyem() : base(
			605,
			SpecieElgyem.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}