using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User receives 1/4 the damage it inflicts in recoil.
	public class MoveSubmission : Move
	{
		public MoveSubmission() : base(
			"Submission",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			0.8, 0 // Acc & Priority
		) {}
	}
}