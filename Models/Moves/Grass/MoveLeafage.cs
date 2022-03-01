using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveLeafage : Move
	{
		public MoveLeafage() : base(
			"Leafage",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			40, 40,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}