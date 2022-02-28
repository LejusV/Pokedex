using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts damage to all opposing Pokémon and increases the user's Attack, Defense, Special Attack, Special Defense, and Speed by one stage each.
	public class MoveClangorousSoulblaze : Move
	{
		public MoveClangorousSoulblaze() : base(
			"Clangorous-Soulblaze",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 185,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}