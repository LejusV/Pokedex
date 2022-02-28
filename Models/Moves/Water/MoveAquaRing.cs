using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Restores 1/16 of the user's max HP each turn.
	public class MoveAquaRing : Move
	{
		public MoveAquaRing() : base(
			"Aqua-Ring",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}