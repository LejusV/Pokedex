using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense by two stages.
	public class MoveIronDefense : Move
	{
		public MoveIronDefense() : base(
			"Iron-Defense",
			Steel.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}