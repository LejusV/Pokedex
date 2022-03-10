using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Removes any immunity to Ground damage.
	public class MoveSmackDown : Move
	{
		public MoveSmackDown() : base(
			"Smack-Down",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}