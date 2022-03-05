using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Changes the target's ability to Simple.
	public class MoveSimpleBeam : Move
	{
		public MoveSimpleBeam() : base(
			"Simple-Beam",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}