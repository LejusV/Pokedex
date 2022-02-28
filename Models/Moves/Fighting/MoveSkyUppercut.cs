using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage and can hit Bounce and Fly users.
	public class MoveSkyUppercut : Move
	{
		public MoveSkyUppercut() : base(
			"Sky-Uppercut",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 85,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}