using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSkitterSmack : Move
	{
		public MoveSkitterSmack() : base(
			"Skitter-Smack",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 70,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}