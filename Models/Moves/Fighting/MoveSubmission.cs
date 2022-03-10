using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

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
			80, 0 // Acc & Priority
		) {}
	}
}