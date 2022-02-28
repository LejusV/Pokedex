using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Crawdaunt Specie to store common natural stats of all Crawdaunts
	#region SpecieCrawdaunt
	public class SpecieCrawdaunt : PokemonSpecie
	{
#nullable enable
		private static SpecieCrawdaunt? _instance = null;
#nullable restore
        public static SpecieCrawdaunt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCrawdaunt();
                }
                return _instance;
            }
        }

		#region SpecieCrawdaunt Builder
		public SpecieCrawdaunt() : base(
			"Crawdaunt",
			63, // HPs
			120, 85, // Attack & Defense
			90, 55, // Special Attack & Defense
			55			
		) {}
		#endregion
	}
	#endregion

	//Crawdaunt Pokemon Class
	#region Crawdaunt
	public class Crawdaunt : Pokemon
	{
		#region Crawdaunt Builders
		/// <summary>
		/// Crawdaunt Builder waiting for a Nickname & a Level
		/// </summary>
		public Crawdaunt(string nickname, int level)
		: base(
				342,
				SpecieCrawdaunt.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crawdaunt Builder only waiting for a Level
		/// </summary>
		public Crawdaunt(int level)
		: base(
				342,
				SpecieCrawdaunt.Instance, // Pokemon Specie
				"Crawdaunt", level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crawdaunt Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Crawdaunt() : base(
			342,
			SpecieCrawdaunt.Instance, // Pokemon Specie
			Water.Instance, Dark.Instance			
		) {}
		#endregion
	}
	#endregion
}