using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSlam : Move
	{
		public MoveSlam() : base(
			"Slam",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			75, 0 // Acc & Priority
			
		) {}
	}
}