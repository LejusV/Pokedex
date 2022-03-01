using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveViceGrip : Move
	{
		public MoveViceGrip() : base(
			"Vice-Grip",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 55,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}