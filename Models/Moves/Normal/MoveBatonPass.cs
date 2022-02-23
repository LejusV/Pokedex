using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Allows the trainer to switch out the user and pass effects along to its replacement.
	public class MoveBatonPass : Move
	{
		public MoveBatonPass() : base(
			"Baton-Pass",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}