using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents any moves from hitting the user this turn.
	public class MoveDetect : Move
	{
		public MoveDetect() : base(
			"Detect",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}