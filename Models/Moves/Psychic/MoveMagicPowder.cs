using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveMagicPowder : Move
	{
		public MoveMagicPowder() : base(
			"Magic-Powder",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}