using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Changes all normal moves to electric moves for the rest of the turn.
	public class MoveIonDeluge : Move
	{
		public MoveIonDeluge() : base(
			"Ion-Deluge",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			25, null,// PP & Pow
			null, 1 // Acc & Priority
		) {}
	}
}