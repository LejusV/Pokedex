using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.
	public class MoveRoost : Move
	{
		public MoveRoost() : base(
			"Roost",
			Flying.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}