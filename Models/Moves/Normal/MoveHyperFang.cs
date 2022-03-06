using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to make the target flinch.
	public class MoveHyperFang : Move
	{
		public MoveHyperFang() : base(
			"Hyper-Fang",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}