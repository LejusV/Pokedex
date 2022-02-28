using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveNeverEndingNightmarePhysical : Move
	{
		public MoveNeverEndingNightmarePhysical() : base(
			"Never-Ending-Nightmare--Physical",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}