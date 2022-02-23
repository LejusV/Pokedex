using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDragonClaw : Move
	{
		public MoveDragonClaw() : base(
			"Dragon-Claw",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}