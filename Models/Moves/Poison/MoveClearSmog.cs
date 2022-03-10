using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Removes all of the target's stat modifiers.
	public class MoveClearSmog : Move
	{
		public MoveClearSmog() : base(
			"Clear-Smog",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 50,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}