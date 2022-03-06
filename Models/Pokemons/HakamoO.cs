using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Hakamo-O Specie to store common natural stats of all Hakamo-Os
	#region SpecieHakamo-O
	public class SpecieHakamoO : PokemonSpecie
	{
#nullable enable
		private static SpecieHakamoO? _instance = null;
#nullable restore
        public static SpecieHakamoO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHakamoO();
                }
                return _instance;
            }
        }

		#region SpecieHakamo-O Builder
		public SpecieHakamoO() : base(
			"Hakamo-O",
			1.2,
			47.0,
			55, // HPs
			75, 90, // Attack & Defense
			65, 70, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Hakamo-O Pokemon Class
	#region Hakamo-O
	public class HakamoO : Pokemon
	{
		#region Hakamo-O Builders
		/// <summary>
		/// Hakamo-O Builder waiting for a Nickname & a Level
		/// </summary>
		public HakamoO(string nickname, int level)
		: base(
				783,
				SpecieHakamoO.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hakamo-O Builder only waiting for a Level
		/// </summary>
		public HakamoO(int level)
		: base(
				783,
				SpecieHakamoO.Instance, // Pokemon Specie
				"Hakamo-O", level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hakamo-O Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public HakamoO() : base(
			783,
			SpecieHakamoO.Instance, // Pokemon Specie
			Dragon.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}