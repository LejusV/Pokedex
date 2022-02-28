using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Cleanses the user of a burn, paralysis, or poison.
	public class MoveRefresh : Move
	{
		public MoveRefresh() : base(
			"Refresh",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}