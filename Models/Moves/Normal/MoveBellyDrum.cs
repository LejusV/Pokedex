using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User pays half its max HP to max out its Attack.
	public class MoveBellyDrum : Move
	{
		public MoveBellyDrum() : base(
			"Belly-Drum",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}