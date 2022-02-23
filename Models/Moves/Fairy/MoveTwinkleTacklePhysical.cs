using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTwinkleTacklePhysical : Move
	{
		public MoveTwinkleTacklePhysical() : base(
			"Twinkle-Tackle--Physical",
			Fairy.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}