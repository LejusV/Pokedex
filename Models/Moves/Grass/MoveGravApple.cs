using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Defense by one stage after inflicting damage.
	public class MoveGravApple : Move
	{
		public MoveGravApple() : base(
			"Grav-Apple",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}