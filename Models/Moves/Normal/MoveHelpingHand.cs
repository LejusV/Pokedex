using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Ally's next move inflicts half more damage.
	public class MoveHelpingHand : Move
	{
		public MoveHelpingHand() : base(
			"Helping-Hand",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 5 // Acc & Priority
			
		) {}
	}
}