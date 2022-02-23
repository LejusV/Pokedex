using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 40% chance to lower the target's accuracy by one stage.
	public class MoveNightDaze : Move
	{
		public MoveNightDaze() : base(
			"Night-Daze",
			Dark.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 85,// PP & Pow
			95, 0 // Acc & Priority
			
		) {}
	}
}