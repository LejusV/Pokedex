using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Special Attack by two stages after inflicting damage.
	public class MoveOverheat : Move
	{
		public MoveOverheat() : base(
			"Overheat",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}