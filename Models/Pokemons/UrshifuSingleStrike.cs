using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Urshifu-Single-Strike Specie to store common natural stats of all Urshifu-Single-Strikes
	#region SpecieUrshifu-Single-Strike
	public class SpecieUrshifuSingleStrike : PokemonSpecie
	{
#nullable enable
		private static SpecieUrshifuSingleStrike? _instance = null;
#nullable restore
        public static SpecieUrshifuSingleStrike Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUrshifuSingleStrike();
                }
                return _instance;
            }
        }

		#region SpecieUrshifu-Single-Strike Builder
		public SpecieUrshifuSingleStrike() : base(
			"Urshifu-Single-Strike",
			100, // HPs
			130, 100, // Attack & Defense
			63, 60, // Special Attack & Defense
			97		
		)
		{
			this._height = 19;
			this._weight = 1050;
		}
		#endregion
	}
	#endregion

	//Urshifu-Single-Strike Pokemon Class
	#region Urshifu-Single-Strike
	public class UrshifuSingleStrike : Pokemon
	{
		#region Urshifu-Single-Strike Builders
		/// <summary>
		/// Urshifu-Single-Strike Builder waiting for a Nickname & a Level
		/// </summary>
		public UrshifuSingleStrike(string nickname, int level)
		: base(
				892,
				SpecieUrshifuSingleStrike.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Urshifu-Single-Strike Builder only waiting for a Level
		/// </summary>
		public UrshifuSingleStrike(int level)
		: base(
				892,
				SpecieUrshifuSingleStrike.Instance, // Pokemon Specie
				"Urshifu-Single-Strike", level,
				Fighting.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Urshifu-Single-Strike Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public UrshifuSingleStrike() : base(
			892,
			SpecieUrshifuSingleStrike.Instance, // Pokemon Specie
			Fighting.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}