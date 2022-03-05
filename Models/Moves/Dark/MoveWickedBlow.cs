using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveWickedBlow : Move
	{
		public MoveWickedBlow() : base(
			"Wicked-Blow",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}