using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Sets Reflect on the user's side of the field after inflicting damage.
	public class MoveSnipeShot : Move
	{
		public MoveSnipeShot() : base(
			"Snipe-Shot",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}