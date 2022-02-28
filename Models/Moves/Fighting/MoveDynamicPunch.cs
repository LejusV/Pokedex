using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to confuse the target.
	public class MoveDynamicPunch : Move
	{
		public MoveDynamicPunch() : base(
			"Dynamic-Punch",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			50, 0 // Acc & Priority
		) {}
	}
}