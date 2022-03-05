using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveHornAttack : Move
	{
		public MoveHornAttack() : base(
			"Horn-Attack",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}