using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveVineWhip : Move
	{
		public MoveVineWhip() : base(
			"Vine-Whip",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 45,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}