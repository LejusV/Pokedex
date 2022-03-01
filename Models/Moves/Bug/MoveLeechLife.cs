using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveLeechLife : Move
	{
		public MoveLeechLife() : base(
			"Leech-Life",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}