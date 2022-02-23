using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Cures the entire party of major status effects after inflicting damage.
	public class MoveStuffCheeks : Move
	{
		public MoveStuffCheeks() : base(
			"Stuff-Cheeks",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}