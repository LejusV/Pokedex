using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveIceShard : Move
	{
		public MoveIceShard() : base(
			"Ice-Shard",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 40,// PP & Pow
			1.0, 1 // Acc & Priority
		) {}
	}
}