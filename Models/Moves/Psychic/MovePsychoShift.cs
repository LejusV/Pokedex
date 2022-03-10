using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Transfers the user's major status effect to the target.
	public class MovePsychoShift : Move
	{
		public MovePsychoShift() : base(
			"Psycho-Shift",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}