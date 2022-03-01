using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDragonHammer : Move
	{
		public MoveDragonHammer() : base(
			"Dragon-Hammer",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}