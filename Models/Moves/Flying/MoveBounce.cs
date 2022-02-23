using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User bounces high into the air, dodging all attacks, and hits next turn.
	public class MoveBounce : Move
	{
		public MoveBounce() : base(
			"Bounce",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 85,// PP & Pow
			85, 0 // Acc & Priority
			
		) {}
	}
}