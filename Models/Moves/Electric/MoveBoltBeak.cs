using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveBoltBeak : Move
	{
		public MoveBoltBeak() : base(
			"Bolt-Beak",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}