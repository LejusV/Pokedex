using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense by two stages.
	public class MoveAcidArmor : Move
	{
		public MoveAcidArmor() : base(
			"Acid-Armor",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}