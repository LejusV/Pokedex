using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Permanently becomes the target's last used move.
	public class MoveSketch : Move
	{
		public MoveSketch() : base(
			"Sketch",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}