using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Guarantees a critical hit with the user's next move.
	public class MoveLaserFocus : Move
	{
		public MoveLaserFocus() : base(
			"Laser-Focus",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}