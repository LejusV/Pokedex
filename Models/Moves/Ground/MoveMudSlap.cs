using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's accuracy by one stage.
	public class MoveMudSlap : Move
	{
		public MoveMudSlap() : base(
			"Mud-Slap",
			Ground.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 20,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}