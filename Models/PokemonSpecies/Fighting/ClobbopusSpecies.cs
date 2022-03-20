using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Clobbopus Species to store common natural stats of all Clobbopuss
	#region ClobbopusSpecies
	public class ClobbopusSpecies : PokemonSpecies
	{
#nullable enable
		private static ClobbopusSpecies? _instance = null;
#nullable restore
        public static ClobbopusSpecies Instance => _instance ?? (_instance = new ClobbopusSpecies());

		#region ClobbopusSpecies Constructor
		public ClobbopusSpecies() : base(
			852,
			"Clobbopus",
			Fighting.Instance,
			0.6,
			4.0,
			new PokemonStats(
				50, // HPs
				68, 60, // Attack & Defense
				50, 50, // Spacial Attack & Defense
				32 // Speed
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