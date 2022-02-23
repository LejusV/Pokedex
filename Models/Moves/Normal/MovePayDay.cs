using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Scatters money on the ground worth five times the user's level.
	public class MovePayDay : Move
	{
		public MovePayDay() : base(
			"Pay-Day",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 40,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}