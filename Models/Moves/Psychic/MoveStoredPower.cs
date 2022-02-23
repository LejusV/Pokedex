using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power is higher the more the user's stats have been raised, to a maximum of 31×.
	public class MoveStoredPower : Move
	{
		public MoveStoredPower() : base(
			"Stored-Power",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 20,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}