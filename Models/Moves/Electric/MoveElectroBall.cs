using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power is higher when the user has greater Speed than the target, up to a maximum of 150.
	public class MoveElectroBall : Move
	{
		public MoveElectroBall() : base(
			"Electro-Ball",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}