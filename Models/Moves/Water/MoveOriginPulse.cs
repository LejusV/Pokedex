using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveOriginPulse : Move
	{
		public MoveOriginPulse() : base(
			"Origin-Pulse",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 110,// PP & Pow
			0.85, 0 // Acc & Priority
		) {}
	}
}