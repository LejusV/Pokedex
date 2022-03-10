using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//With Fusion Flare, inflicts double damage.
	public class MoveFusionBolt : Move
	{
		public MoveFusionBolt() : base(
			"Fusion-Bolt",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}