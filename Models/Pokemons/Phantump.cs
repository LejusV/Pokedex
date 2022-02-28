using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Phantump Specie to store common natural stats of all Phantumps
	#region SpeciePhantump
	public class SpeciePhantump : PokemonSpecie
	{
#nullable enable
		private static SpeciePhantump? _instance = null;
#nullable restore
        public static SpeciePhantump Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePhantump();
                }
                return _instance;
            }
        }

		#region SpeciePhantump Builder
		public SpeciePhantump() : base(
			"Phantump",
			43, // HPs
			70, 48, // Attack & Defense
			50, 60, // Special Attack & Defense
			38			
		) {}
		#endregion
	}
	#endregion

	//Phantump Pokemon Class
	#region Phantump
	public class Phantump : Pokemon
	{
		#region Phantump Builders
		/// <summary>
		/// Phantump Builder waiting for a Nickname & a Level
		/// </summary>
		public Phantump(string nickname, int level)
		: base(
				708,
				SpeciePhantump.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phantump Builder only waiting for a Level
		/// </summary>
		public Phantump(int level)
		: base(
				708,
				SpeciePhantump.Instance, // Pokemon Specie
				"Phantump", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phantump Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Phantump() : base(
			708,
			SpeciePhantump.Instance, // Pokemon Specie
			Ghost.Instance, Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}