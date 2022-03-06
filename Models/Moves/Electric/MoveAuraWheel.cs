using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveAuraWheel : Move
	{
		public MoveAuraWheel() : base(
			"Aura-Wheel",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 110,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}