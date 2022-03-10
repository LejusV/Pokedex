using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//If the target is paralyzed, inflicts double damage and cures the paralysis.
	public class MoveSmellingSalts : Move
	{
		public MoveSmellingSalts() : base(
			"Smelling-Salts",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}