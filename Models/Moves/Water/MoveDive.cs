using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User dives underwater, dodging all attacks, and hits next turn.
	public class MoveDive : Move
	{
		public MoveDive() : base(
			"Dive",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}