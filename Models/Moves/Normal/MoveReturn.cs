using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Power increases with happiness, up to a maximum of 102.
	public class MoveReturn : Move
	{
		public MoveReturn() : base(
			"Return",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}