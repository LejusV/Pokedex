using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveZippyZap : Move
	{
		public MoveZippyZap() : base(
			"Zippy-Zap",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			1.0, 2 // Acc & Priority
		) {}
	}
}