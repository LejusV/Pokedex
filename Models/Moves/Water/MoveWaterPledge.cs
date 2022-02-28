using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//With Grass Pledge, halves opposing Pokémon's Speed for four turns.
	public class MoveWaterPledge : Move
	{
		public MoveWaterPledge() : base(
			"Water-Pledge",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}