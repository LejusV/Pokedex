using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveSpacialRend : Move
	{
		public MoveSpacialRend() : base(
			"Spacial-Rend",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			95, 0 // Acc & Priority
			
		) {}
	}
}