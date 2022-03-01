using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a higher chance to confuse the target when the recorded sound is louder.
	public class MoveChatter : Move
	{
		public MoveChatter() : base(
			"Chatter",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 65,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}