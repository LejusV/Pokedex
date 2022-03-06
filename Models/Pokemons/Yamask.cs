using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Yamask Specie to store common natural stats of all Yamasks
	#region SpecieYamask
	public class SpecieYamask : PokemonSpecie
	{
#nullable enable
		private static SpecieYamask? _instance = null;
#nullable restore
        public static SpecieYamask Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYamask();
                }
                return _instance;
            }
        }

		#region SpecieYamask Builder
		public SpecieYamask() : base(
			"Yamask",
			38, // HPs
			30, 85, // Attack & Defense
			55, 65, // Special Attack & Defense
			30		
		)
		{
			this._height = 5;
			this._weight = 15;
		}
		#endregion
	}
	#endregion

	//Yamask Pokemon Class
	#region Yamask
	public class Yamask : Pokemon
	{
		#region Yamask Builders
		/// <summary>
		/// Yamask Builder waiting for a Nickname & a Level
		/// </summary>
		public Yamask(string nickname, int level)
		: base(
				562,
				SpecieYamask.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamask Builder only waiting for a Level
		/// </summary>
		public Yamask(int level)
		: base(
				562,
				SpecieYamask.Instance, // Pokemon Specie
				"Yamask", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamask Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Yamask() : base(
			562,
			SpecieYamask.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}