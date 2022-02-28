using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Metapod Specie to store common natural stats of all Metapods
	#region SpecieMetapod
	public class SpecieMetapod : PokemonSpecie
	{
#nullable enable
		private static SpecieMetapod? _instance = null;
#nullable restore
        public static SpecieMetapod Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMetapod();
                }
                return _instance;
            }
        }

		#region SpecieMetapod Builder
		public SpecieMetapod() : base(
			"Metapod",
			50, // HPs
			20, 55, // Attack & Defense
			25, 25, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Metapod Pokemon Class
	#region Metapod
	public class Metapod : Pokemon
	{
		#region Metapod Builders
		/// <summary>
		/// Metapod Builder waiting for a Nickname & a Level
		/// </summary>
		public Metapod(string nickname, int level)
		: base(
				11,
				SpecieMetapod.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metapod Builder only waiting for a Level
		/// </summary>
		public Metapod(int level)
		: base(
				11,
				SpecieMetapod.Instance, // Pokemon Specie
				"Metapod", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metapod Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Metapod() : base(
			11,
			SpecieMetapod.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}