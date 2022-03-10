using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.
	public class MoveSlackOff : Move
	{
		public MoveSlackOff() : base(
			"Slack-Off",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}