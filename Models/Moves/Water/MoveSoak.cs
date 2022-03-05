using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Changes the target's type to Water.
	public class MoveSoak : Move
	{
		public MoveSoak() : base(
			"Soak",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}