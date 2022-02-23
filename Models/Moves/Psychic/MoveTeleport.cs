using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Immediately ends wild battles.  No effect otherwise.
	public class MoveTeleport : Move
	{
		public MoveTeleport() : base(
			"Teleport",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, -6 // Acc & Priority
			
		) {}
	}
}