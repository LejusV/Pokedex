using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts damage equal to the user's level.
	public class MoveNightShade : Move
	{
		public MoveNightShade() : base(
			"Night-Shade",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}