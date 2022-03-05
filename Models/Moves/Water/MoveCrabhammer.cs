using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveCrabhammer : Move
	{
		public MoveCrabhammer() : base(
			"Crabhammer",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}