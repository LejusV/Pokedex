using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents the target from leaving battle.
	public class MoveMeanLook : Move
	{
		public MoveMeanLook() : base(
			"Mean-Look",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}