using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Slowpoke Specie to store common natural stats of all Slowpokes
	#region SpecieSlowpoke
	public class SpecieSlowpoke : PokemonSpecie
	{
#nullable enable
		private static SpecieSlowpoke? _instance = null;
#nullable restore
        public static SpecieSlowpoke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlowpoke();
                }
                return _instance;
            }
        }

		#region SpecieSlowpoke Builder
		public SpecieSlowpoke() : base(
			"Slowpoke",
			90, // HPs
			65, 65, // Attack & Defense
			40, 40, // Special Attack & Defense
			15			
		) {}
		#endregion
	}
	#endregion

	//Slowpoke Pokemon Class
	#region Slowpoke
	public class Slowpoke : Pokemon
	{
		#region Slowpoke Builders
		/// <summary>
		/// Slowpoke Builder waiting for a Nickname & a Level
		/// </summary>
		public Slowpoke(string nickname, int level)
		: base(
				79,
				SpecieSlowpoke.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowpoke Builder only waiting for a Level
		/// </summary>
		public Slowpoke(int level)
		: base(
				79,
				SpecieSlowpoke.Instance, // Pokemon Specie
				"Slowpoke", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowpoke Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Slowpoke() : base(
			79,
			SpecieSlowpoke.Instance, // Pokemon Specie
			Water.Instance, Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}