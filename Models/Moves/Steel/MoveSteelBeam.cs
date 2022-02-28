using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts damage, and the user takes damage equal to half of its max HP, rounded up.
	public class MoveSteelBeam : Move
	{
		public MoveSteelBeam() : base(
			"Steel-Beam",
			Steel.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 140,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}