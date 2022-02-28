using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Scyther Specie to store common natural stats of all Scythers
	#region SpecieScyther
	public class SpecieScyther : PokemonSpecie
	{
#nullable enable
		private static SpecieScyther? _instance = null;
#nullable restore
        public static SpecieScyther Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScyther();
                }
                return _instance;
            }
        }

		#region SpecieScyther Builder
		public SpecieScyther() : base(
			"Scyther",
			70, // HPs
			110, 80, // Attack & Defense
			55, 80, // Special Attack & Defense
			105			
		) {}
		#endregion
	}
	#endregion

	//Scyther Pokemon Class
	#region Scyther
	public class Scyther : Pokemon
	{
		#region Scyther Builders
		/// <summary>
		/// Scyther Builder waiting for a Nickname & a Level
		/// </summary>
		public Scyther(string nickname, int level)
		: base(
				123,
				SpecieScyther.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scyther Builder only waiting for a Level
		/// </summary>
		public Scyther(int level)
		: base(
				123,
				SpecieScyther.Instance, // Pokemon Specie
				"Scyther", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scyther Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Scyther() : base(
			123,
			SpecieScyther.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}