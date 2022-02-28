using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts damage equal to half the target's HP.
	public class MoveSuperFang : Move
	{
		public MoveSuperFang() : base(
			"Super-Fang",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}