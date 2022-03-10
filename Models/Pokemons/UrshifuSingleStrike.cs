using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Urshifu-Single-Strike Species to store common natural stats of all Urshifu-Single-Strikes
	#region SpeciesUrshifu-Single-Strike
	public class SpeciesUrshifuSingleStrike : PokemonSpecies
	{
#nullable enable
		private static SpeciesUrshifuSingleStrike? _instance = null;
#nullable restore
        public static SpeciesUrshifuSingleStrike Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesUrshifuSingleStrike();
                }
                return _instance;
            }
        }

		#region SpeciesUrshifu-Single-Strike Constructor
		public SpeciesUrshifuSingleStrike() : base(
			"Urshifu-Single-Strike",
			1.9,
			105.0,
			100, // HPs
			130, 100, // Attack & Defense
			63, 60, // Special Attack & Defense
			97		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				
			};
		}
		#endregion
	}
	#endregion

	//Urshifu-Single-Strike PokemonInstance Class
	#region Urshifu-Single-Strike
	public class UrshifuSingleStrikeInstance : PokemonInstance
	{
		#region Urshifu-Single-Strike Constructors
		/// <summary>
		/// Urshifu-Single-Strike Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public UrshifuSingleStrikeInstance(string nickname, int level)
		: base(
				892,
				SpeciesUrshifuSingleStrike.Instance, // Pokemon Species
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
		public UrshifuSingleStrikeInstance(int level)
		: base(
				892,
				SpeciesUrshifuSingleStrike.Instance, // PokemonInstance Species
				"Urshifu-Single-Strike", level,
				Fighting.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Urshifu-Single-Strike Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public UrshifuSingleStrike() : base(
			892,
			SpeciesUrshifuSingleStrike.Instance, // PokemonInstance Species
			Fighting.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}