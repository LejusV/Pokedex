using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxFlare : Move
	{
		public MoveMaxFlare() : base(
			"Max-Flare",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}