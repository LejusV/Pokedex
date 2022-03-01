using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDragonEnergy : Move
	{
		public MoveDragonEnergy() : base(
			"Dragon-Energy",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}