using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the user's evasion by one stage.
	public class MoveDoubleTeam : Move
	{
		public MoveDoubleTeam() : base(
			"Double-Team",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}