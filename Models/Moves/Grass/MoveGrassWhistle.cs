using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveGrassWhistle : Move
	{
		public MoveGrassWhistle() : base(
			"Grass-Whistle",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			0.55, 0 // Acc & Priority
		) {}
	}
}