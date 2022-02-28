using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Randomly selects and uses one of the trainer's other Pokémon's moves.
	public class MoveAssist : Move
	{
		public MoveAssist() : base(
			"Assist",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}