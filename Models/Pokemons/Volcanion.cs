using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Volcanion Specie to store common natural stats of all Volcanions
	#region SpecieVolcanion
	public class SpecieVolcanion : PokemonSpecie
	{
#nullable enable
		private static SpecieVolcanion? _instance = null;
#nullable restore
        public static SpecieVolcanion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVolcanion();
                }
                return _instance;
            }
        }

		#region SpecieVolcanion Builder
		public SpecieVolcanion() : base(
			"Volcanion",
			80, // HPs
			110, 120, // Attack & Defense
			130, 90, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Volcanion Pokemon Class
	#region Volcanion
	public class Volcanion : Pokemon
	{
		#region Volcanion Builders
		/// <summary>
		/// Volcanion Builder waiting for a Nickname & a Level
		/// </summary>
		public Volcanion(string nickname, int level)
		: base(
				721,
				SpecieVolcanion.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcanion Builder only waiting for a Level
		/// </summary>
		public Volcanion(int level)
		: base(
				721,
				SpecieVolcanion.Instance, // Pokemon Specie
				"Volcanion", level,
				Fire.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcanion Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Volcanion() : base(
			721,
			SpecieVolcanion.Instance, // Pokemon Specie
			Fire.Instance, Water.Instance			
		) {}
		#endregion
	}
	#endregion
}