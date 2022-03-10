using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSteelRoller : Move
	{
		public MoveSteelRoller() : base(
			"Steel-Roller",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 130,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}