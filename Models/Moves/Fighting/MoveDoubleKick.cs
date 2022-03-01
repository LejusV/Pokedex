using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveDoubleKick : Move
	{
		public MoveDoubleKick() : base(
			"Double-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 30,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}