using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack and accuracy by one stage.
	public class MoveHoneClaws : Move
	{
		public MoveHoneClaws() : base(
			"Hone-Claws",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}