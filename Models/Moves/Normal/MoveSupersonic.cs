using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Confuses the target.
	public class MoveSupersonic : Move
	{
		public MoveSupersonic() : base(
			"Supersonic",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			0.55, 0 // Acc & Priority
		) {}
	}
}