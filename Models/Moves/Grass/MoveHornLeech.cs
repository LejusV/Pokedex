using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveHornLeech : Move
	{
		public MoveHornLeech() : base(
			"Horn-Leech",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}