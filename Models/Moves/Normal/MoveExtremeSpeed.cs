using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveExtremeSpeed : Move
	{
		public MoveExtremeSpeed() : base(
			"Extreme-Speed",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 80,// PP & Pow
			1.0, 2 // Acc & Priority
		) {}
	}
}