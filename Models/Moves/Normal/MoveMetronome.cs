using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Randomly selects and uses any move in the game.
	public class MoveMetronome : Move
	{
		public MoveMetronome() : base(
			"Metronome",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}