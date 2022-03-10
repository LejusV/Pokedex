using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//If the user takes damage before attacking, the attack is canceled.
	public class MoveFocusPunch : Move
	{
		public MoveFocusPunch() : base(
			"Focus-Punch",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 150,// PP & Pow
			100, -3 // Acc & Priority
		) {}
	}
}