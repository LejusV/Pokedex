using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveGigaDrain : Move
	{
		public MoveGigaDrain() : base(
			"Giga-Drain",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}