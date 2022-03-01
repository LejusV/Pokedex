using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveEerieSpell : Move
	{
		public MoveEerieSpell() : base(
			"Eerie-Spell",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}