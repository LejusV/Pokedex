using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has double power if the user has no held item.
	public class MoveAcrobatics : Move
	{
		public MoveAcrobatics() : base(
			"Acrobatics",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 55,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}