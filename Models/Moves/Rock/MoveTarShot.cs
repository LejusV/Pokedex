using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveTarShot : Move
	{
		public MoveTarShot() : base(
			"Tar-Shot",
			Rock.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}