using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveHydroPump : Move
	{
		public MoveHydroPump() : base(
			"Hydro-Pump",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 110,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}