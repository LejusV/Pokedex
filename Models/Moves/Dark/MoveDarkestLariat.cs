using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Ignores the target's stat modifiers.
	public class MoveDarkestLariat : Move
	{
		public MoveDarkestLariat() : base(
			"Darkest-Lariat",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}