using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveEternabeam : Move
	{
		public MoveEternabeam() : base(
			"Eternabeam",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 160,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}