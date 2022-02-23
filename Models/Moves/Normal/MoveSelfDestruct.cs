using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User faints.
	public class MoveSelfDestruct : Move
	{
		public MoveSelfDestruct() : base(
			"Self-Destruct",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 200,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}