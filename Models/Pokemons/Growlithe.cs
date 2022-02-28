using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Growlithe Specie to store common natural stats of all Growlithes
	#region SpecieGrowlithe
	public class SpecieGrowlithe : PokemonSpecie
	{
#nullable enable
		private static SpecieGrowlithe? _instance = null;
#nullable restore
        public static SpecieGrowlithe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrowlithe();
                }
                return _instance;
            }
        }

		#region SpecieGrowlithe Builder
		public SpecieGrowlithe() : base(
			"Growlithe",
			55, // HPs
			70, 45, // Attack & Defense
			70, 50, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Growlithe Pokemon Class
	#region Growlithe
	public class Growlithe : Pokemon
	{
		#region Growlithe Builders
		/// <summary>
		/// Growlithe Builder waiting for a Nickname & a Level
		/// </summary>
		public Growlithe(string nickname, int level)
		: base(
				58,
				SpecieGrowlithe.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Growlithe Builder only waiting for a Level
		/// </summary>
		public Growlithe(int level)
		: base(
				58,
				SpecieGrowlithe.Instance, // Pokemon Specie
				"Growlithe", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Growlithe Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Growlithe() : base(
			58,
			SpecieGrowlithe.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}