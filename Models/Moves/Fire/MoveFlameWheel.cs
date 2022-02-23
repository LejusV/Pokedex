using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.  Lets frozen Pokémon thaw themselves.
	public class MoveFlameWheel : Move
	{
		public MoveFlameWheel() : base(
			"Flame-Wheel",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 60,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}