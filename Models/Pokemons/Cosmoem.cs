using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cosmoem Specie to store common natural stats of all Cosmoems
	#region SpecieCosmoem
	public class SpecieCosmoem : PokemonSpecie
	{
#nullable enable
		private static SpecieCosmoem? _instance = null;
#nullable restore
        public static SpecieCosmoem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCosmoem();
                }
                return _instance;
            }
        }

		#region SpecieCosmoem Builder
		public SpecieCosmoem() : base(
			"Cosmoem",
			0.1,
			999.9,
			43, // HPs
			29, 131, // Attack & Defense
			29, 131, // Special Attack & Defense
			37		
		)
		{}
		#endregion
	}
	#endregion

	//Cosmoem Pokemon Class
	#region Cosmoem
	public class Cosmoem : Pokemon
	{
		#region Cosmoem Builders
		/// <summary>
		/// Cosmoem Builder waiting for a Nickname & a Level
		/// </summary>
		public Cosmoem(string nickname, int level)
		: base(
				790,
				SpecieCosmoem.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmoem Builder only waiting for a Level
		/// </summary>
		public Cosmoem(int level)
		: base(
				790,
				SpecieCosmoem.Instance, // Pokemon Specie
				"Cosmoem", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmoem Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cosmoem() : base(
			790,
			SpecieCosmoem.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}