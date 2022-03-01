using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to confuse the target.
	public class MoveHurricane : Move
	{
		public MoveHurricane() : base(
			"Hurricane",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 110,// PP & Pow
			0.7, 0 // Acc & Priority
		) {}
	}
}