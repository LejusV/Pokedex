using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nihilego Specie to store common natural stats of all Nihilegos
	#region SpecieNihilego
	public class SpecieNihilego : PokemonSpecie
	{
#nullable enable
		private static SpecieNihilego? _instance = null;
#nullable restore
        public static SpecieNihilego Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNihilego();
                }
                return _instance;
            }
        }

		#region SpecieNihilego Builder
		public SpecieNihilego() : base(
			"Nihilego",
			109, // HPs
			53, 47, // Attack & Defense
			127, 131, // Special Attack & Defense
			103			
		) {}
		#endregion
	}
	#endregion

	//Nihilego Pokemon Class
	#region Nihilego
	public class Nihilego : Pokemon
	{
		#region Nihilego Builders
		/// <summary>
		/// Nihilego Builder waiting for a Nickname & a Level
		/// </summary>
		public Nihilego(string nickname, int level)
		: base(
				793,
				SpecieNihilego.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nihilego Builder only waiting for a Level
		/// </summary>
		public Nihilego(int level)
		: base(
				793,
				SpecieNihilego.Instance, // Pokemon Specie
				"Nihilego", level,
				Rock.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nihilego Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Nihilego() : base(
			793,
			SpecieNihilego.Instance, // Pokemon Specie
			Rock.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}