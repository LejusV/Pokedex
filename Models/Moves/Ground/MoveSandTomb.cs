using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveSandTomb : Move
	{
		public MoveSandTomb() : base(
			"Sand-Tomb",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 35,// PP & Pow
			85, 0 // Acc & Priority
			
		) {}
	}
}