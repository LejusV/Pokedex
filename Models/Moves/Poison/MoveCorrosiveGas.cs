using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveCorrosiveGas : Move
	{
		public MoveCorrosiveGas() : base(
			"Corrosive-Gas",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}