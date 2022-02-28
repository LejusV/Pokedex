using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Changes the weather to rain for five turns.
	public class MoveRainDance : Move
	{
		public MoveRainDance() : base(
			"Rain-Dance",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}