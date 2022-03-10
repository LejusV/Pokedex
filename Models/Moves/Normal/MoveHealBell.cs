using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Cures the entire party of major status effects.
	public class MoveHealBell : Move
	{
		public MoveHealBell() : base(
			"Heal-Bell",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}