using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.
	public class MoveMilkDrink : Move
	{
		public MoveMilkDrink() : base(
			"Milk-Drink",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}