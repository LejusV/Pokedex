using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Ensures that the user's next move will hit the target.
	public class MoveMindReader : Move
	{
		public MoveMindReader() : base(
			"Mind-Reader",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}