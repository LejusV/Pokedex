using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDragonPulse : Move
	{
		public MoveDragonPulse() : base(
			"Dragon-Pulse",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}