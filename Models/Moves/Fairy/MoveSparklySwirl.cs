using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSparklySwirl : Move
	{
		public MoveSparklySwirl() : base(
			"Sparkly-Swirl",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 120,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}