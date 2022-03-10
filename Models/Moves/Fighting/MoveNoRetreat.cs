using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn
	public class MoveNoRetreat : Move
	{
		public MoveNoRetreat() : base(
			"No-Retreat",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}