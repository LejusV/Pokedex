using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Defense by one stage after inflicting damage.
	public class MoveFireLash : Move
	{
		public MoveFireLash() : base(
			"Fire-Lash",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}