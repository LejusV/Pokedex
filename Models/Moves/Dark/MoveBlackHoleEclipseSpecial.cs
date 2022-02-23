using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBlackHoleEclipseSpecial : Move
	{
		public MoveBlackHoleEclipseSpecial() : base(
			"Black-Hole-Eclipse--Special",
			Dark.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}