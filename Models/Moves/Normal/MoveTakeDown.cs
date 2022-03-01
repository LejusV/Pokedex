using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User receives 1/4 the damage it inflicts in recoil.
	public class MoveTakeDown : Move
	{
		public MoveTakeDown() : base(
			"Take-Down",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 90,// PP & Pow
			0.85, 0 // Acc & Priority
		) {}
	}
}