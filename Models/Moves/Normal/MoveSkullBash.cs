using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense by one stage.  User charges for one turn before attacking.
	public class MoveSkullBash : Move
	{
		public MoveSkullBash() : base(
			"Skull-Bash",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 130,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}