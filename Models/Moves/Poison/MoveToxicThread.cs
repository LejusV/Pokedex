using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Poisons the target and lowers its Speed by one stage.
	public class MoveToxicThread : Move
	{
		public MoveToxicThread() : base(
			"Toxic-Thread",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}