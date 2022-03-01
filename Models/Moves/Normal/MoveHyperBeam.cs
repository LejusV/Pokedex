using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveHyperBeam : Move
	{
		public MoveHyperBeam() : base(
			"Hyper-Beam",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}