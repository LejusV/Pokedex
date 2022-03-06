using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Watchog Specie to store common natural stats of all Watchogs
	#region SpecieWatchog
	public class SpecieWatchog : PokemonSpecie
	{
#nullable enable
		private static SpecieWatchog? _instance = null;
#nullable restore
        public static SpecieWatchog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWatchog();
                }
                return _instance;
            }
        }

		#region SpecieWatchog Builder
		public SpecieWatchog() : base(
			"Watchog",
			60, // HPs
			85, 69, // Attack & Defense
			60, 69, // Special Attack & Defense
			77		
		)
		{
			this._height = 11;
			this._weight = 270;
		}
		#endregion
	}
	#endregion

	//Watchog Pokemon Class
	#region Watchog
	public class Watchog : Pokemon
	{
		#region Watchog Builders
		/// <summary>
		/// Watchog Builder waiting for a Nickname & a Level
		/// </summary>
		public Watchog(string nickname, int level)
		: base(
				505,
				SpecieWatchog.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Watchog Builder only waiting for a Level
		/// </summary>
		public Watchog(int level)
		: base(
				505,
				SpecieWatchog.Instance, // Pokemon Specie
				"Watchog", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Watchog Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Watchog() : base(
			505,
			SpecieWatchog.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}