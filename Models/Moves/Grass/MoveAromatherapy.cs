using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Cures the entire party of major status effects.
	public class MoveAromatherapy : Move
	{
		public MoveAromatherapy() : base(
			"Aromatherapy",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}