using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveHeartStamp : Move
	{
		public MoveHeartStamp() : base(
			"Heart-Stamp",
			Psychic.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 60,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}