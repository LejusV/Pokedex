using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Randomly uses one of the user's other three moves.  Only works if the user is sleeping.
	public class MoveSleepTalk : Move
	{
		public MoveSleepTalk() : base(
			"Sleep-Talk",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}