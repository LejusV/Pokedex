using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Disables moves and immunities that involve flying or levitating for five turns.
	public class MoveGravity : Move
	{
		public MoveGravity() : base(
			"Gravity",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}