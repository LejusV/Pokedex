using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the user's Speed by two stages.
	public class MoveAgility : Move
	{
		public MoveAgility() : base(
			"Agility",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}