using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveShockWave : Move
	{
		public MoveShockWave() : base(
			"Shock-Wave",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}