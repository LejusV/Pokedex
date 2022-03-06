using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's evasion by one stage.  Removes field effects from the enemy field.
	public class MoveDefog : Move
	{
		public MoveDefog() : base(
			"Defog",
			Flying.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}