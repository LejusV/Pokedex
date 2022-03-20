using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Urshifu-Single-Strike Species to store common natural stats of all Urshifu-Single-Strikes
	#region Urshifu-Single-StrikeSpecies
	public class UrshifuSingleStrikeSpecies : PokemonSpecies
	{
#nullable enable
		private static UrshifuSingleStrikeSpecies? _instance = null;
#nullable restore
        public static UrshifuSingleStrikeSpecies Instance => _instance ?? (_instance = new UrshifuSingleStrikeSpecies());

		#region Urshifu-Single-StrikeSpecies Constructor
		public UrshifuSingleStrikeSpecies() : base(
			892,
			"Urshifu-Single-Strike",
			Fighting.Instance, Dark.Instance,
			1.9,
			105.0,
			new PokemonStats(
				100, // HPs
				130, 100, // Attack & Defense
				63, 60, // Spacial Attack & Defense
				97 // Speed
			)			
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
}