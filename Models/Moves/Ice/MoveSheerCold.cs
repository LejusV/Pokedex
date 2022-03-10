using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Causes a one-hit KO.
	public class MoveSheerCold : Move
	{
		public MoveSheerCold() : base(
			"Sheer-Cold",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, null,// PP & Pow
			30, 0 // Acc & Priority
		) {}
	}
}