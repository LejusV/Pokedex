using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Heals the target for half its max HP.
	public class MoveHealPulse : Move
	{
		public MoveHealPulse() : base(
			"Heal-Pulse",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}