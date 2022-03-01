using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveScaleShot : Move
	{
		public MoveScaleShot() : base(
			"Scale-Shot",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 25,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}