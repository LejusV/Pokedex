using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage.
	public class MoveBoomburst : Move
	{
		public MoveBoomburst() : base(
			"Boomburst",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 140,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}