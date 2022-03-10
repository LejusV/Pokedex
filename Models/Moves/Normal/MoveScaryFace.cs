using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by two stages.
	public class MoveScaryFace : Move
	{
		public MoveScaryFace() : base(
			"Scary-Face",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}