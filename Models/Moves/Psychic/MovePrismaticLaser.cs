using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MovePrismaticLaser : Move
	{
		public MovePrismaticLaser() : base(
			"Prismatic-Laser",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 160,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}