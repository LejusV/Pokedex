using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Blocks damaging attacks and damages attacking Pokémon for 1/8 their max HP.
	public class MoveSpikyShield : Move
	{
		public MoveSpikyShield() : base(
			"Spiky-Shield",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}