using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Eelektrik Specie to store common natural stats of all Eelektriks
	#region SpecieEelektrik
	public class SpecieEelektrik : PokemonSpecie
	{
#nullable enable
		private static SpecieEelektrik? _instance = null;
#nullable restore
        public static SpecieEelektrik Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEelektrik();
                }
                return _instance;
            }
        }

		#region SpecieEelektrik Builder
		public SpecieEelektrik() : base(
			"Eelektrik",
			1.2,
			22.0,
			65, // HPs
			85, 70, // Attack & Defense
			75, 70, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Eelektrik Pokemon Class
	#region Eelektrik
	public class Eelektrik : Pokemon
	{
		#region Eelektrik Builders
		/// <summary>
		/// Eelektrik Builder waiting for a Nickname & a Level
		/// </summary>
		public Eelektrik(string nickname, int level)
		: base(
				603,
				SpecieEelektrik.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektrik Builder only waiting for a Level
		/// </summary>
		public Eelektrik(int level)
		: base(
				603,
				SpecieEelektrik.Instance, // Pokemon Specie
				"Eelektrik", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektrik Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Eelektrik() : base(
			603,
			SpecieEelektrik.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}