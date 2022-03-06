using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Jangmo-O Specie to store common natural stats of all Jangmo-Os
	#region SpecieJangmo-O
	public class SpecieJangmoO : PokemonSpecie
	{
#nullable enable
		private static SpecieJangmoO? _instance = null;
#nullable restore
        public static SpecieJangmoO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJangmoO();
                }
                return _instance;
            }
        }

		#region SpecieJangmo-O Builder
		public SpecieJangmoO() : base(
			"Jangmo-O",
			0.6,
			29.7,
			45, // HPs
			55, 65, // Attack & Defense
			45, 45, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Jangmo-O Pokemon Class
	#region Jangmo-O
	public class JangmoO : Pokemon
	{
		#region Jangmo-O Builders
		/// <summary>
		/// Jangmo-O Builder waiting for a Nickname & a Level
		/// </summary>
		public JangmoO(string nickname, int level)
		: base(
				782,
				SpecieJangmoO.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jangmo-O Builder only waiting for a Level
		/// </summary>
		public JangmoO(int level)
		: base(
				782,
				SpecieJangmoO.Instance, // Pokemon Specie
				"Jangmo-O", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jangmo-O Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public JangmoO() : base(
			782,
			SpecieJangmoO.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}