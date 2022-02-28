using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTripleAxel : Move
	{
		public MoveTripleAxel() : base(
			"Triple-Axel",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 20,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}