using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveRazorLeaf : Move
	{
		public MoveRazorLeaf() : base(
			"Razor-Leaf",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 55,// PP & Pow
			0.95, 0 // Acc & Priority
		) {}
	}
}