using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Causes damage when opposing Pokémon switch in.
	public class MoveStealthRock : Move
	{
		public MoveStealthRock() : base(
			"Stealth-Rock",
			Rock.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}