using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Groudon Specie to store common natural stats of all Groudons
	#region SpecieGroudon
	public class SpecieGroudon : PokemonSpecie
	{
#nullable enable
		private static SpecieGroudon? _instance = null;
#nullable restore
        public static SpecieGroudon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGroudon();
                }
                return _instance;
            }
        }

		#region SpecieGroudon Builder
		public SpecieGroudon() : base(
			"Groudon",
			100, // HPs
			150, 140, // Attack & Defense
			100, 90, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Groudon Pokemon Class
	#region Groudon
	public class Groudon : Pokemon
	{
		#region Groudon Builders
		/// <summary>
		/// Groudon Builder waiting for a Nickname & a Level
		/// </summary>
		public Groudon(string nickname, int level)
		: base(
				383,
				SpecieGroudon.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Groudon Builder only waiting for a Level
		/// </summary>
		public Groudon(int level)
		: base(
				383,
				SpecieGroudon.Instance, // Pokemon Specie
				"Groudon", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Groudon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Groudon() : base(
			383,
			SpecieGroudon.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}