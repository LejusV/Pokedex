using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxPhantasm : Move
	{
		public MoveMaxPhantasm() : base(
			"Max-Phantasm",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}