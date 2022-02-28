using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Special Attack by two stages after inflicting damage.
	public class MoveLeafStorm : Move
	{
		public MoveLeafStorm() : base(
			"Leaf-Storm",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}