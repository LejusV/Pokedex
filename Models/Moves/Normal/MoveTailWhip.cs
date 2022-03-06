using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Defense by one stage.
	public class MoveTailWhip : Move
	{
		public MoveTailWhip() : base(
			"Tail-Whip",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}