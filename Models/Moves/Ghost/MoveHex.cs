using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has double power if the target has a major status ailment.
	public class MoveHex : Move
	{
		public MoveHex() : base(
			"Hex",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}