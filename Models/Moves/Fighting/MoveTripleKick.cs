using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits three times, increasing power by 100% with each successful hit.
	public class MoveTripleKick : Move
	{
		public MoveTripleKick() : base(
			"Triple-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}