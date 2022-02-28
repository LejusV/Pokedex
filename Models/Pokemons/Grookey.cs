using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grookey Specie to store common natural stats of all Grookeys
	#region SpecieGrookey
	public class SpecieGrookey : PokemonSpecie
	{
#nullable enable
		private static SpecieGrookey? _instance = null;
#nullable restore
        public static SpecieGrookey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrookey();
                }
                return _instance;
            }
        }

		#region SpecieGrookey Builder
		public SpecieGrookey() : base(
			"Grookey",
			50, // HPs
			65, 50, // Attack & Defense
			40, 40, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Grookey Pokemon Class
	#region Grookey
	public class Grookey : Pokemon
	{
		#region Grookey Builders
		/// <summary>
		/// Grookey Builder waiting for a Nickname & a Level
		/// </summary>
		public Grookey(string nickname, int level)
		: base(
				810,
				SpecieGrookey.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grookey Builder only waiting for a Level
		/// </summary>
		public Grookey(int level)
		: base(
				810,
				SpecieGrookey.Instance, // Pokemon Specie
				"Grookey", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grookey Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Grookey() : base(
			810,
			SpecieGrookey.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}