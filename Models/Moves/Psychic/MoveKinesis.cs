using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's accuracy by one stage.
	public class MoveKinesis : Move
	{
		public MoveKinesis() : base(
			"Kinesis",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			0.8, 0 // Acc & Priority
		) {}
	}
}