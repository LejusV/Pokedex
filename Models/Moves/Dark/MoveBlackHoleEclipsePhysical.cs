using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBlackHoleEclipsePhysical : Move
	{
		public MoveBlackHoleEclipsePhysical() : base(
			"Black-Hole-Eclipse--Physical",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}