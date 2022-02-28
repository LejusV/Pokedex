using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveHeadbutt : Move
	{
		public MoveHeadbutt() : base(
			"Headbutt",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}