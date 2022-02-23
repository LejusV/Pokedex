using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Speed by one stage.
	public class MoveIcyWind : Move
	{
		public MoveIcyWind() : base(
			"Icy-Wind",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 55,// PP & Pow
			95, 0 // Acc & Priority
			
		) {}
	}
}