using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Calculates damage with the target's attacking stat.
	public class MoveFoulPlay : Move
	{
		public MoveFoulPlay() : base(
			"Foul-Play",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 95,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}