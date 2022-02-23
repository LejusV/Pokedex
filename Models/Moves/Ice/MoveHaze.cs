using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Resets all Pokémon's stats, accuracy, and evasion.
	public class MoveHaze : Move
	{
		public MoveHaze() : base(
			"Haze",
			Ice.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}