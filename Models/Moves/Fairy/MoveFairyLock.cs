using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents all Pokémon from fleeing or switching out during the next turn.
	public class MoveFairyLock : Move
	{
		public MoveFairyLock() : base(
			"Fairy-Lock",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}