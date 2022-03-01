using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power is 100 times the amount of energy Stockpiled.
	public class MoveSpitUp : Move
	{
		public MoveSpitUp() : base(
			"Spit-Up",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}