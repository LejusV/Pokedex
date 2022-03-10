using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Cures the target of a major status ailment and heals the user for 50% of its max HP.
	public class MovePurify : Move
	{
		public MovePurify() : base(
			"Purify",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}