using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power is higher the more the user's stats have been raised, to a maximum of 31×.
	public class MovePowerTrip : Move
	{
		public MovePowerTrip() : base(
			"Power-Trip",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 20,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}