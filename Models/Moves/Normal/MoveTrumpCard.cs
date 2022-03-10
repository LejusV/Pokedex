using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Power increases when this move has less PP, up to a maximum of 200.
	public class MoveTrumpCard : Move
	{
		public MoveTrumpCard() : base(
			"Trump-Card",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}