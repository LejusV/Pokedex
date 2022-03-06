using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Espeon Specie to store common natural stats of all Espeons
	#region SpecieEspeon
	public class SpecieEspeon : PokemonSpecie
	{
#nullable enable
		private static SpecieEspeon? _instance = null;
#nullable restore
        public static SpecieEspeon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEspeon();
                }
                return _instance;
            }
        }

		#region SpecieEspeon Builder
		public SpecieEspeon() : base(
			"Espeon",
			0.9,
			26.5,
			65, // HPs
			65, 60, // Attack & Defense
			130, 95, // Special Attack & Defense
			110		
		)
		{}
		#endregion
	}
	#endregion

	//Espeon Pokemon Class
	#region Espeon
	public class Espeon : Pokemon
	{
		#region Espeon Builders
		/// <summary>
		/// Espeon Builder waiting for a Nickname & a Level
		/// </summary>
		public Espeon(string nickname, int level)
		: base(
				196,
				SpecieEspeon.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espeon Builder only waiting for a Level
		/// </summary>
		public Espeon(int level)
		: base(
				196,
				SpecieEspeon.Instance, // Pokemon Specie
				"Espeon", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espeon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Espeon() : base(
			196,
			SpecieEspeon.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}