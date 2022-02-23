using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxOvergrowth : Move
	{
		public MoveMaxOvergrowth() : base(
			"Max-Overgrowth",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}