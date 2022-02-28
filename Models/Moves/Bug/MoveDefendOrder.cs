using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense and Special Defense by one stage.
	public class MoveDefendOrder : Move
	{
		public MoveDefendOrder() : base(
			"Defend-Order",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}