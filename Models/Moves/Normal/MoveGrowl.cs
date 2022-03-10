using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by one stage.
	public class MoveGrowl : Move
	{
		public MoveGrowl() : base(
			"Growl",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}