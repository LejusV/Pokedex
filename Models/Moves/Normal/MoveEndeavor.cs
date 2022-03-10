using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's HP to equal the user's.
	public class MoveEndeavor : Move
	{
		public MoveEndeavor() : base(
			"Endeavor",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}