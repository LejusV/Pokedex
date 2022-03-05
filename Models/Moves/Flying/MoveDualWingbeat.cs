using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDualWingbeat : Move
	{
		public MoveDualWingbeat() : base(
			"Dual-Wingbeat",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 40,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}