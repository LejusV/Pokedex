using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to burn the target.
	public class MoveLavaPlume : Move
	{
		public MoveLavaPlume() : base(
			"Lava-Plume",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}