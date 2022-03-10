using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Defense by two stages.
	public class MoveMetalSound : Move
	{
		public MoveMetalSound() : base(
			"Metal-Sound",
			Steel.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}