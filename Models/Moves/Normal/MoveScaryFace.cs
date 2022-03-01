using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by two stages.
	public class MoveScaryFace : Move
	{
		public MoveScaryFace() : base(
			"Scary-Face",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}