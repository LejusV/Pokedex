using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dragapult Species to store common natural stats of all Dragapults
	#region DragapultSpecies
	public class DragapultSpecies : PokemonSpecies
	{
#nullable enable
		private static DragapultSpecies? _instance = null;
#nullable restore
        public static DragapultSpecies Instance => _instance ?? (_instance = new DragapultSpecies());

		#region DragapultSpecies Constructor
		public DragapultSpecies() : base(
			887,
			"Dragapult",
			Dragon.Instance, Ghost.Instance,
			3.0,
			50.0,
			new PokemonStats(
				88, // HPs
				120, 75, // Attack & Defense
				100, 75, // Spacial Attack & Defense
				142 // Speed
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