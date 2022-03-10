using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveAppleAcid : Move
	{
		public MoveAppleAcid() : base(
			"Apple-Acid",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}