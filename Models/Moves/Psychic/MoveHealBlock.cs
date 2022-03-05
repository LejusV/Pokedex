using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents target from restoring its HP for five turns.
	public class MoveHealBlock : Move
	{
		public MoveHealBlock() : base(
			"Heal-Block",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}