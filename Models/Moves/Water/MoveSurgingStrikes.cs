using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSurgingStrikes : Move
	{
		public MoveSurgingStrikes() : base(
			"Surging-Strikes",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 25,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}