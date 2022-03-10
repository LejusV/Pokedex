using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the PP of the target's last used move by 4.
	public class MoveSpite : Move
	{
		public MoveSpite() : base(
			"Spite",
			Ghost.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}