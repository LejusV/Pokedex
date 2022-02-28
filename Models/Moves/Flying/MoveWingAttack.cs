using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveWingAttack : Move
	{
		public MoveWingAttack() : base(
			"Wing-Attack",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}