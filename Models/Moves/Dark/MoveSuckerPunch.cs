using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Only works if the target is about to use a damaging move.
	public class MoveSuckerPunch : Move
	{
		public MoveSuckerPunch() : base(
			"Sucker-Punch",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 70,// PP & Pow
			100, 1 // Acc & Priority
			
		) {}
	}
}