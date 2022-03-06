using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Attack by two stages.
	public class MoveEerieImpulse : Move
	{
		public MoveEerieImpulse() : base(
			"Eerie-Impulse",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}