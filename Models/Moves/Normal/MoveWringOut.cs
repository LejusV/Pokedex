using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power increases against targets with more HP remaining, up to a maximum of 121 power.
	public class MoveWringOut : Move
	{
		public MoveWringOut() : base(
			"Wring-Out",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}