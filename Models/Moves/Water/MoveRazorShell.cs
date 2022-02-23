using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to lower the target's Defense by one stage.
	public class MoveRazorShell : Move
	{
		public MoveRazorShell() : base(
			"Razor-Shell",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 75,// PP & Pow
			95, 0 // Acc & Priority
			
		) {}
	}
}