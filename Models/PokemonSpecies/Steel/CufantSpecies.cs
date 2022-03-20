using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cufant Species to store common natural stats of all Cufants
	#region CufantSpecies
	public class CufantSpecies : PokemonSpecies
	{
#nullable enable
		private static CufantSpecies? _instance = null;
#nullable restore
        public static CufantSpecies Instance => _instance ?? (_instance = new CufantSpecies());

		#region CufantSpecies Constructor
		public CufantSpecies() : base(
			878,
			"Cufant",
			Steel.Instance,
			1.2,
			100.0,
			new PokemonStats(
				72, // HPs
				80, 49, // Attack & Defense
				40, 49, // Spacial Attack & Defense
				40 // Speed
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