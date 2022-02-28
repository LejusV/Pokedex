using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Anorith Specie to store common natural stats of all Anoriths
	#region SpecieAnorith
	public class SpecieAnorith : PokemonSpecie
	{
#nullable enable
		private static SpecieAnorith? _instance = null;
#nullable restore
        public static SpecieAnorith Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAnorith();
                }
                return _instance;
            }
        }

		#region SpecieAnorith Builder
		public SpecieAnorith() : base(
			"Anorith",
			45, // HPs
			95, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			75			
		) {}
		#endregion
	}
	#endregion

	//Anorith Pokemon Class
	#region Anorith
	public class Anorith : Pokemon
	{
		#region Anorith Builders
		/// <summary>
		/// Anorith Builder waiting for a Nickname & a Level
		/// </summary>
		public Anorith(string nickname, int level)
		: base(
				347,
				SpecieAnorith.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Anorith Builder only waiting for a Level
		/// </summary>
		public Anorith(int level)
		: base(
				347,
				SpecieAnorith.Instance, // Pokemon Specie
				"Anorith", level,
				Rock.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Anorith Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Anorith() : base(
			347,
			SpecieAnorith.Instance, // Pokemon Specie
			Rock.Instance, Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}