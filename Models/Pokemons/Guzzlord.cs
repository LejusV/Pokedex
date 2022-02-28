using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Guzzlord Specie to store common natural stats of all Guzzlords
	#region SpecieGuzzlord
	public class SpecieGuzzlord : PokemonSpecie
	{
#nullable enable
		private static SpecieGuzzlord? _instance = null;
#nullable restore
        public static SpecieGuzzlord Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGuzzlord();
                }
                return _instance;
            }
        }

		#region SpecieGuzzlord Builder
		public SpecieGuzzlord() : base(
			"Guzzlord",
			223, // HPs
			101, 53, // Attack & Defense
			97, 53, // Special Attack & Defense
			43			
		) {}
		#endregion
	}
	#endregion

	//Guzzlord Pokemon Class
	#region Guzzlord
	public class Guzzlord : Pokemon
	{
		#region Guzzlord Builders
		/// <summary>
		/// Guzzlord Builder waiting for a Nickname & a Level
		/// </summary>
		public Guzzlord(string nickname, int level)
		: base(
				799,
				SpecieGuzzlord.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Guzzlord Builder only waiting for a Level
		/// </summary>
		public Guzzlord(int level)
		: base(
				799,
				SpecieGuzzlord.Instance, // Pokemon Specie
				"Guzzlord", level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Guzzlord Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Guzzlord() : base(
			799,
			SpecieGuzzlord.Instance, // Pokemon Specie
			Dark.Instance, Dragon.Instance			
		) {}
		#endregion
	}
	#endregion
}