using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePulverizingPancake : Move
	{
		public MovePulverizingPancake() : base(
			"Pulverizing-Pancake",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 210,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}