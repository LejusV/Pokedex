using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Paralyzes the target.
	public class MoveThunderWave : Move
	{
		public MoveThunderWave() : base(
			"Thunder-Wave",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}