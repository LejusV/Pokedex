using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Changes the weather to a sandstorm for five turns.
	public class MoveSandstorm : Move
	{
		public MoveSandstorm() : base(
			"Sandstorm",
			Rock.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}