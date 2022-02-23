using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by one stage after inflicting damage.
	public class MoveLunge : Move
	{
		public MoveLunge() : base(
			"Lunge",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}