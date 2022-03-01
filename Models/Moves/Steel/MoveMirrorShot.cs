using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to lower the target's accuracy by one stage.
	public class MoveMirrorShot : Move
	{
		public MoveMirrorShot() : base(
			"Mirror-Shot",
			Steel.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			0.85, 0 // Acc & Priority
		) {}
	}
}