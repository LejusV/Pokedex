using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Uses the target's last used move.
	public class MoveMirrorMove : Move
	{
		public MoveMirrorMove() : base(
			"Mirror-Move",
			Flying.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}