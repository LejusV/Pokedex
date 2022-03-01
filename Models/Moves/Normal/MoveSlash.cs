using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveSlash : Move
	{
		public MoveSlash() : base(
			"Slash",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}