using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User receives 1/3 the damage inflicted in recoil.
	public class MoveDoubleEdge : Move
	{
		public MoveDoubleEdge() : base(
			"Double-Edge",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 120,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}