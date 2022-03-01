using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveExpandingForce : Move
	{
		public MoveExpandingForce() : base(
			"Expanding-Force",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}