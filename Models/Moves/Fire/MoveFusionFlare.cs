using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//With Fusion Bolt, inflicts double damage.
	public class MoveFusionFlare : Move
	{
		public MoveFusionFlare() : base(
			"Fusion-Flare",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}