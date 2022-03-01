using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by two stages.
	public class MoveCottonSpore : Move
	{
		public MoveCottonSpore() : base(
			"Cotton-Spore",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}