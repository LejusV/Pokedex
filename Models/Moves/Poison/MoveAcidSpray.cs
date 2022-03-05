using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Defense by two stages.
	public class MoveAcidSpray : Move
	{
		public MoveAcidSpray() : base(
			"Acid-Spray",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}