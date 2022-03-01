using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveStrength : Move
	{
		public MoveStrength() : base(
			"Strength",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}