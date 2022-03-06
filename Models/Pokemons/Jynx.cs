using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Jynx Specie to store common natural stats of all Jynxs
	#region SpecieJynx
	public class SpecieJynx : PokemonSpecie
	{
#nullable enable
		private static SpecieJynx? _instance = null;
#nullable restore
        public static SpecieJynx Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJynx();
                }
                return _instance;
            }
        }

		#region SpecieJynx Builder
		public SpecieJynx() : base(
			"Jynx",
			1.4,
			40.6,
			65, // HPs
			50, 35, // Attack & Defense
			115, 95, // Special Attack & Defense
			95		
		)
		{}
		#endregion
	}
	#endregion

	//Jynx Pokemon Class
	#region Jynx
	public class Jynx : Pokemon
	{
		#region Jynx Builders
		/// <summary>
		/// Jynx Builder waiting for a Nickname & a Level
		/// </summary>
		public Jynx(string nickname, int level)
		: base(
				124,
				SpecieJynx.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jynx Builder only waiting for a Level
		/// </summary>
		public Jynx(int level)
		: base(
				124,
				SpecieJynx.Instance, // Pokemon Specie
				"Jynx", level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jynx Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Jynx() : base(
			124,
			SpecieJynx.Instance, // Pokemon Specie
			Ice.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}