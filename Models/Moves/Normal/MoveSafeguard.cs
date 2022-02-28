using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Protects the user's field from major status ailments and confusion for five turns.
	public class MoveSafeguard : Move
	{
		public MoveSafeguard() : base(
			"Safeguard",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			25, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}