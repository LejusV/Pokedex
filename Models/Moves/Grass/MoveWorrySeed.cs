using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Changes the target's ability to Insomnia.
	public class MoveWorrySeed : Move
	{
		public MoveWorrySeed() : base(
			"Worry-Seed",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}