using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Causes a one-hit KO.
	public class MoveGuillotine : Move
	{
		public MoveGuillotine() : base(
			"Guillotine",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			30, 0 // Acc & Priority
			
		) {}
	}
}