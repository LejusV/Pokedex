using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Averages Attack and Special Attack with the target.
	public class MovePowerSplit : Move
	{
		public MovePowerSplit() : base(
			"Power-Split",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}