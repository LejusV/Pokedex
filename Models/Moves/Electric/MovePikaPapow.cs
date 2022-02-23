using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePikaPapow : Move
	{
		public MovePikaPapow() : base(
			"Pika-Papow",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}